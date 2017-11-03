# UniKeyEventDispatcher

## これはなに?
Unityでキーイベントっぽい事をするそれです．
解説は[この記事](https://qiita.com/AirBeans5956/items/4d9f83fe208944c86f2a)まで

## どう使うの?
1. このリポジトリをcloneする，もしくはDownload ZIPする
2. `UniKeyEventDispatcher.unitypackage`をImportする
3. `UniKeyEventDispatcher/Prefabs/KeyEventDispatcherのPrefab`をSceneに配置
4. キーイベントを取得したいコンポーネントで，キー押下時のイベント`IKeyDownEvent`，キー押上時のイベント`IKeyUpEvent`を実装
5. 配置したPrefabの`KeyEventDispatcher`コンポーネントのプロパティに，キーイベントを取得したいコンポーネントを含む`GameObject`を追加

## サンプルはある?
CloneしたProjectの`Scenes/Sample`を確認してみてください．  
このサンプルは押下/押上されたキーを表示する，ただそれだけのサンプルです．

## Interface仕様
### IKeyDownEvent
#### インタフェース一覧
- `void OnKeyDown(List<KeyCode> downKeyList)`  
  - 任意のキー/ボタン押下時に実装先のメソッドが呼ばれます．  
  - 引数
    - `downKeyList`: 押下されたキー/ボタンに対応するUnityの`KeyCode`が含まれます．

### IKeyUpEvent
#### インタフェース
- `void OnKeyUp(List<KeyCode> upKeyList)`
  - 任意のキー/ボタン押上時に実装先のメソッドが呼ばれます．
  - 引数
    - `upKeyList`: 押上されたキー/ボタンに対応するUnityの`KeyCode`が含まれます．
