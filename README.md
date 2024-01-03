# What is findZipCode
住所から郵便番号を取得するプログラムです。
![findZipCodeScreenShot](https://github.com/charliekato/findZipCode/assets/122329903/48e52f9b-9fb7-414b-a905-bdc1b7676490)

# How to run
郵便番号データにエクセルファイルが必要です。郵便番号がアップデートされた場合はエクセルファイルをアップデートします。
エクセルファイルは実行ファイル(exe)と同一のフォルダーに入れておく必要があります。
[ここ](https://github.com/charliekato/zennbook/blob/main/articles/findZipCode/zipcode.xlsx)からエクセルファイルはDownloadできます。
実行ファイルは[ここ](https://github.com/charliekato/zennbook/blob/main/articles/findZipCode/findZipCode.exe)からダウンロードできます。

エクセルファイルの仕様は次の通りです。
二つのシートが必要です。
zipcode という名前のシートと、 prefという名前のシートです。
zipcodeには、
1行目は見出し行　zipcode, pref, city, streetの四つのカラムが必要です。

prefという名前のシートには県名を羅列するだけでいいです。ただし、先頭行は見出し行でprefとします。

