# alarm_clock
[![Open in Visual Studio Code](https://img.shields.io/static/v1?logo=visualstudiocode&label=&message=Open%20in%20Visual%20Studio%20Code&labelColor=2c2c32&color=007acc&logoColor=007acc)](https://open.vscode.dev/hosoya17/alarm_clock)
![](https://img.shields.io/github/repo-size/hosoya17/alarm_clock)
## 開発の概要
Windows上で動作するアラーム・目覚ましアプリです。
## システムの概要
・コンボボックスで時、分の指定をします。<br>
・指定した時間になったら、wavファイルが再生されます。<br>
・スヌーズ、停止ボタンのいずれかをクリックします。<br>
・停止ボタンの場合、wavファイルが停止されます。<br>
・スヌーズボタンの場合、wavファイルが停止され、10分後にまたwavファイルが再生されます。
### 開発環境
開発環境：Visual Studio 2022<br>
開発言語：C#
[![My Skills](https://skillicons.dev/icons?i=visualstudio,cs)](https://skillicons.dev)
### 注意事項
Form1.csの65行目の""の中に再生したいwavファイルのパスを記述してからご使用ください。<br>
```cs
string soundFilePath = "";//wavファイルのパスを指定してください.。
```
