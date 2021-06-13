all: main

main: cl
	Compiler\csc.exe /reference:System.Windows.Forms.dll /target:winexe /out:bin\recomendation-tariff.exe src\MainForm.cs src\MainForm.Designer.cs src\Program.cs src\logic.cs src\AddDataBaseForm.Designer.cs src\AddDataBaseForm.cs

cl:
	rm -rf bin\recomendation-tariff.exe

test:
	Compiler\csc.exe /reference:System.Windows.Forms.dll /target:exe /out:bin\TESTS_recomendation-tariff.exe src\logic.cs src\Tests.cs