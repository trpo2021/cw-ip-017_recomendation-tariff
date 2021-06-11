all: main

main: cl
	Compiler\csc.exe /reference:System.Windows.Forms.dll /target:winexe /out:bin\recomendation-tariff.exe src\MainForm.cs src\MainForm.Designer.cs src\Program.cs src\ClassTariff.cs src\AddDataBaseForm.Designer.cs src\AddDataBaseForm.cs

cl:
	rm -rf bin\recomendation-tariff.exe 