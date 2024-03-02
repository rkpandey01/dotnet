pipeline {
    
    agent any

    stages {
        stage('test cmd') {
            steps {
               echo 'hiii'
            }
        }
        stage('unit tests') {
            steps {
                echo 'performing unit tests'
            }
        }
        stage('build') {
            steps {
                echo 'build app'
            }
        }
        stage('deploy dev') {
            steps {
                echo 'deploy on dev'
            }
        }
        
        stage('deploy uat') {
            input{
                message 'deploy on uat?'
                ok 'to uat'
            }
            steps {
                echo 'deploy on dev'
            }
        }
        
    }
}
