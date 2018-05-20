pipeline {
  agent any
  stages {
    stage('restore') {
      steps {
        bat 'nuget restore NinjectExample.sln'
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