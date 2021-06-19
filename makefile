all: main

main: clean
	compiler\csc.exe /target:winexe /out:bin\recomendation-tariff.exe src\MainForm.cs src\MainForm.Designer.cs src\Program.cs src\logic.cs src\AddDataBaseForm.Designer.cs src\AddDataBaseForm.cs src\StartForm.cs src\StartForm.Designer.cs src\DeletedDataBaseForm.Designer.cs src\DeletedDataBaseForm.cs

test:
	compiler\csc.exe /target:exe /out:bin\TESTS_recomendation-tariff.exe src\logic.cs src\Tests.cs

runTests:
	bin/TESTS_recomendation-tariff.exe

clean:
	rm -rf bin\*.exe
