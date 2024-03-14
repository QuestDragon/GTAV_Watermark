# GTA_Watermark - Created By QuestDragon
Version: 1.0.0
## 作成した経緯
fang31氏が作成した、[Activate GTA Watermark](https://www.gta5-mods.com/scripts/activate-gta-watermark) Modの影響を受け、面白かったので自分で.NET版を作ってみました。

fang31氏のModとの違いは、表示する文字とサイズを変更できる点です。

## 機能
ゲーム画面右下に透かし表示ができます。…はい、それだけです。

強いて言えば、iniファイルから表示する文字とサイズを編集できます。

## 機能追加、フィードバックについて
特に機能追加は行いません。

ソースコードは公開しておりますので、追加したい機能等ございましたらご自由にカスタマイズしてくださいませ。

## 開発環境
C#を使用しています。

ScriptHookV DotNetを使用しており、バージョンは3.6.0で開発しています。

## インストール
以下から各種ファイルをダウンロードし、スクリプトMod本体はScriptsフォルダに、前提条件のファイルはGTA5.exeと同じフォルダにコピーしてください。

| [GTAV_Watermark](https://github.com/QuestDragon/GTAV_Watermark/releases/latest/download/GTAV_Watermark.zip) | [ScriptHookV](http://dev-c.com/gtav/scripthookv/) | [ScriptHookV DotNet](https://github.com/scripthookvdotnet/scripthookvdotnet/releases/latest) |
| ------------- | ------------- | ------------- | 

## 各種設定
設定はiniファイルから行います。

### Caption
**Main**：「Windowsのライセンス認証」にあたる文字列を編集できます。

**Sub**：「設定を開き、Windowsのライセンス認証を行ってください。」にあたる文字列を編集できます。

### Scale
**Main**：「Windowsのライセンス認証」にあたる文字列のサイズを編集できます。（推奨サイズ：0.4）

**Sub**：「設定を開き、Windowsのライセンス認証を行ってください。」にあたる文字列のサイズを編集できます。（英語表記推奨サイズ：0.3、日本語表記推奨サイズ：0.2）

## 使い方
ゲームロード時に自動で読み込まれ、画面右下に透かしが表示されます。

## 余談
私も当初はfang31氏のModを使っていたのですが、自分でも作れるのではないだろうか、カスタマイズもできたらなおいいだろうと思い、作成してみました。

fang31氏とは違い、C++の知識は無いので私は.NETで作ってます…ｗ

## 免責事項
本スクリプトModを使用したことにより生じた被害に関して、私QuestDragonは一切の責任を負いかねます。自己責任でご使用ください。

予告なく配布を停止することがあります。予めご了承ください。

改造はご自由にしていただいて構いません。

## 制作者
QuestDragon

## 参考
fang31氏
