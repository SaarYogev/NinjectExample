pipeline {
  agent any
  stages {
    stage('restore') {
      steps {
        bat 'G:\\nuget.exe restore NinjectExample.sln'
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