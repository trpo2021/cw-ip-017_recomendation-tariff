all: main

main: cl
	compiler\csc.exe /target:winexe /out:bin\recomendation-tariff.exe src\MainForm.cs src\MainForm.Designer.cs src\Program.cs src\logic.cs src\AddDataBaseForm.Designer.cs src\AddDataBaseForm.cs

cl:
	rm -rf bin\*.exe

test:
	compiler\csc.exe /target:exe /out:bin\TESTS_recomendation-tariff.exe src\logic.cs src\Tests.cs

CI: cl
	./compiler/csc /target:winexe /out:bin\recomendation-tariff.exe src\MainForm.cs src\MainForm.Designer.cs src\Program.cs src\logic.cs src\AddDataBaseForm.Designer.cs src\AddDataBaseForm.cs

CItest:
	./compiler/csc /target:exe /out:bin\TESTS_recomendation-tariff.exe src\logic.cs src\Tests.cs

TEST_recomendation-tariff:
	./bin/TESTS_recomendation-tariff
