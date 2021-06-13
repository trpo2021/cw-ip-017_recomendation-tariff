all: main

main: cl
	Compiler\csc.exe /target:winexe /out:bin\recomendation-tariff.exe src\MainForm.cs src\MainForm.Designer.cs src\Program.cs src\logic.cs src\AddDataBaseForm.Designer.cs src\AddDataBaseForm.cs

cl:
	rm -rf bin\recomendation-tariff.exe

test:
	Compiler\csc.exe /target:exe /out:bin\TESTS_recomendation-tariff.exe src\logic.cs src\Tests.cs

CI: cl
	./Compiler/csc /target:winexe /out:bin\recomendation-tariff.exe src\MainForm.cs src\MainForm.Designer.cs src\Program.cs src\logic.cs src\AddDataBaseForm.Designer.cs src\AddDataBaseForm.cs

CItest:
	./Compiler/csc /target:exe /out:bin\TESTS_recomendation-tariff.exe src\logic.cs src\Tests.cs