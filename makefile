all: main

main: clean
	compiler\csc.exe /target:winexe /out:bin\recomendation-tariff.exe src\MainForm.cs src\MainForm.Designer.cs src\Program.cs src\logic.cs src\AddDataBaseForm.Designer.cs src\AddDataBaseForm.cs src\Form2.cs src\Form2.Designer.cs

test:
	compiler\csc.exe /target:exe /out:bin\TESTS_recomendation-tariff.exe src\logic.cs src\Tests.cs

runTests:
	bin/TESTS_recomendation-tariff.exe

clean:
	rm -rf bin\*.exe
