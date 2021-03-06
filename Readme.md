﻿UniteSpice受講者のgit練習用リポジトリです。

## 基本コマンド
- git clone : リポジトリをcloneします。
- git checkout : ブランチを切り替えます。 -b オプションをつけることで新しいブランチを作った上でブランチの切り替えができます。
- git status :今ローカルリポジトリがどういう状況か確認できます。
- git add : コミットしたいファイルをステージングにあげます(コミットの前準備だと思ってもらえればOKです。)。"."ですべての変更ファイルをaddできます。
- git commit : commitします。-m "message"を忘れないようにしましょう。
- git push : commitしたコミットをpushしてリモートリポジトリにあげます。pushする時は、origin branch_nameとするのを忘れないようにしましょう。

## 講義では触れてないけど基本コマンド
- git pull : リモートリポジトリの変更点を取り込みます。
- git log :コミットログを確認します。
- git branch : ローカルのブランチ、今自分がいるブランチを確認します。branch branch_nameとすることで新しくブランチを作成できます。
- git init : 直下のファイルを管理下におきます。

## 最初の流れ
1. このブランチをcloneします。
2. その後、新しいブランチを作成して、そこにcheckoutして変更・追加を加えます。
3. statusで変更を確認して、addします。add後は変更がステージングに上がっているかstatusで確認するようにしましょう。
4. コメントをつけてcommitします。commitしたあとはlogで確認するくせをつけましょう。
5. pushします。
6. ついでにPull Requestも出します。
7. (他の人の変更が取り込まれたらpullして確認してみましょう)

## TIPS
- 毎回コマンドを打つのは大変なので、省略形をalias登録しておくと大変楽ちんです。
- git status = git stなど



## その他
- [このサイト](https://backlog.com/ja/git-tutorial/)は入門にとても良いです
- gitが怖くて触れない場合は[こちら](https://learngitbranching.js.org/?locale=ja)で練習してみましょう
- [このサイト](https://employment.en-japan.com/engineerhub/entry/2017/01/31/110000)も役立った気がします
