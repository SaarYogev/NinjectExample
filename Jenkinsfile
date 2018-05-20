pipeline {
  agent any
  stages {
    stage('restore') {
      steps {
        sh 'nuget restore NinjectExample.sln'
      }
    }
  }
  environment {
    Dev = 'Dev'
    Test = 'Test'
    Integ = 'Integ'
    Prod = 'Prod'
  }
}