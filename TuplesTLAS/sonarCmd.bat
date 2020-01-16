set token="42a6e41ed95832e78e184da9bca13eb3df5c53e8"
set pathSonarScanner="C:\sonar-scanner-msbuild-4.7.1.2311-net46\SonarScanner.MSBuild.exe"
set pathMsBuild="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe"
set nameProject="QualitySoftware"
set urlSonarServer="http://localhost:9000"
set version="1.0.0"

echo "Start Sonar analyse ..."
:: start
%pathSonarScanner% begin /k:%nameProject% /d:sonar.host.url=%urlSonarServer% /d:sonar.login="%token%" /v:%version%

:: build
%pathMsBuild% /t:Rebuild

:: end
%pathMsBuild% end /d:sonar.login="%token%""

echo "Analyse done, open SonarQube to see results."
pause