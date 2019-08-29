#!/bin/bash

#### FUNCTIONS

usage() {
  echo "Usage: $0 [options...] "
  echo
  echo "  -l, --use-local-spec        Use local swagger spec instead of latest from ynab"
  exit 1
}

timestamp() {
  date +"%T"
}

#### END FUNCTIONS
#### ARGUMENT PROCESSING

use_local_spec=false
while (( "$#" )); do
  case "$1" in
    -l|--use-local-spec)
      shift
      use_local_spec=true
      ;;
    -h|--help)
      usage
      exit
      ;;
    --) # end of arg parsing
      shift
      break
      ;;
    *)
      usage
      exit 1
      ;;
  esac
  shift
done

#### END ARGUMENT PROCESSING
#### VARIABLES

spec_file="spec-v1-swagger.json"
log_path="./publish.log"

#### END VARIABLES
#### MAIN LOGIC

if [ "$use_local_spec" = false ]
then
  # Download latest spec for the API
  rm -rf "../$spec_file"
  wget "https://api.youneedabudget.com/papi/$spec_file" -O "../$spec_file" | tee -a $log_path
fi

# Use Docker to codegen dotnetcore based on the swagger spec
project_root="../"
docker run --rm --volume "$project_root:/local" openapitools/openapi-generator-cli generate \
  -DapiTests=false \
  -DmodelTests=false \
  --input-spec "/local/$spec_file" \
  --generator-name csharp-netcore \
  --config /local/openapi-config.json \
  --output /local \
  --template-dir /local/openapi-templates/  | tee -a $log_path
