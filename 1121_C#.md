# C#程式設計
## 課堂練習(CE)
### 第三週
#### 1. 設計一 Window Form, 符合下列條件:
* 透過Window Form的方式製作出一個註冊、登入界面，當帳密比對正確時會有一個messagebox跳出登入成功，並清空兩個textbox的內容
* 當帳密比對失敗時會有一個messagebox跳出登入失敗，並清空兩個textbox的內容
* 介面示意圖:
![image](https://hackmd.io/_uploads/BJn9AO0ta.png)

### 第四週
#### 1. 以範例 `CH6_ConsoleEvent1` 進行改寫，使其符合下列條件:
* Speed > 200 => 出現 ==TOO FAST== 警訊
* 50 > Speed > 0 => 出現 ==TOO SLOW== 警訊

### 第五週
#### 1. 參考範例 `CH7_ConsoleInterface3` 之範例程式，模擬System.Array類別，透過介面中的方法 `MyCompareTo()` 進行改寫，使順序呈現 ==最大、最小、次大、次小、中位數== 且 (X,Y)　中順序為先小後大。

### 第七週
#### 1. 對範例 `Ch10_WinTextBox1` 做下列改動:
* 將【市府機構】對應的 TextBox :
    * AutoCompleteMode 設定成 "SuggestAppend"
    * AutoCompleteSource 設定成 "CustomSource"
* 新增一個名為【網址】的 label 與一個填寫【網址資訊】的 TextBox :
    * AutoCompleteMode 設定成 "Append"
    * AutoCompleteSource 設定成 "AllURL"
* 按下確定按鈕後 :
    * 跳出 messagebox，輸出所有 TextBox 填寫內容
    * 將【市府機構】、【地址】對應的 TextBox 內所填寫的資料新增至自身的 AutoCompleteCustomerSource 之串列內
* 介面示意圖:
![image](https://hackmd.io/_uploads/HJ95k_mcT.png)

### 第九週
#### 1. 參考範例 `Ch11_WinTabControl` 製作一個簡易訂票系統:
* TabPages1 主要註冊目前上映的電影，包含:
    * 電影名稱 (textBox)
    * 電影圖片路徑 (textBox, AutoCompleteSource.FileSystem)
    * 電影詳情 (textBox)
    * 電影上映日期 (textBox)
    * 註冊按鈕 (button)
* TabPages2 主要顯示目前所有上映電影的資訊，透過 ComboBox 切換不同上映電影詳情，包含:
    * 電影圖片內容 (pictureBox)
    * 電影名稱 (label)
    * 電影描述 (label)
    * 電影上映日期 (label)
* TabPages3 主要負責訂票，包含:
    * 訂票人 (textBox)
    * 預定電影 (comboBox)
    * 預定時間 (textBox)
    * 確定按鈕 (button)
* TabPage4 主要顯示所有訂票資訊，包含:
    * 列表 (ListBox)
* 介面示意圖:
![image](https://hackmd.io/_uploads/H1Bay_79a.png)
![image](https://hackmd.io/_uploads/S11yeO7q6.png)
![image](https://hackmd.io/_uploads/B1gllOX9T.png)
![image](https://hackmd.io/_uploads/BJTgl_X5p.png)


### 第十四週
#### 1. 參考範例 `Ch19_DataBindingDemo1` ，在保有原先功能下，新增 「新增」、「刪除」按鈕，使用者輸入新一筆資訊後，點選「新增」，將可使資料存入資料庫中；若點選「刪除」，則將該筆資訊進行移除。
> [color=#110830] 編號為系統自動帶入
* 介面示意圖:
![image](https://hackmd.io/_uploads/Hkr3ZOX9T.png)


## 回家作業(HW)
### 第二週 ( 2-1 ~ 2-2 )
#### 1. 輸入每月網內、網外、市話通話時間，及網內、網外簡訊則數，求最佳資費。費率如下表:
![image](https://hackmd.io/_uploads/HyH1Tu0tT.png)
##### 輸入: 網內語音(int)、網外語音(int)、市話語音(int)、網內簡訊(int)、網外簡訊(int)
##### 輸出: 最佳資費類型

#### 2. 有一個數學運算式為1+2+3+4+….+X，輸入X以求得運算式的總和，並將總和轉換為二進位輸出。
##### 輸入: X(int)
##### 輸出: 二進位結果

### 第三週 ( 2-3 ~ 2-5 )
#### 1. 請將各數值進行二進位及十六進位之轉換，並如下方格式儲存至相應之陣列中。
![image](https://hackmd.io/_uploads/B1b8kKCKT.png)

#### 2. 以下為某跨國企業在各地區之銷售額，其股東想了解各地區之銷售狀況及整年度之總銷售額。請協助計算各區域之營業額，並存放總營業額至相應之陣列中，再依各地區營業額進行降冪排序。
![image](https://hackmd.io/_uploads/Sk9p1K0Ya.png)

#### 3. 在9格寬×9格高的大九宮格中有9個3格寬×3格高的小九宮格，每一列與每一行的數字均須包含 1～9，不能缺少，也不能重複。每一小九宮格(3X3的九宮格)的數字均須包含 1～ 9，不能缺少，也不能重複，輸入一組測試資料為9x9的矩陣，判斷九宮格數字是不是一個數獨的正解。
##### 輸入: 9 列數據，每列各9個整數，以空格分開。
##### 輸出: Yes / No (是否符合數獨正解的條件)


### 第四週
#### 1. 每堂課上課時間為三個小時，假設某課程上課開始時間為 1-5 (星期一第五節課)，則此課堂的上課區間為 1-5~1-7(星期一第五節至第七節，共計三小時)，檢查輸入的課程是否衝堂。
##### 輸入: 總課程數、課程編號、一週上課門數、開始上課時間 (ex. 1-5 表示 星期一第五節課)
##### 輸出: Yes / No (是否衝堂)

#### 2. 請排序圖形的順序，排列的順序由以下公式運算出來的值從小到大排序
**$\sqrt[3]{面積}+\sqrt[2]{周長}$**
##### 輸入:
* 圖形數
* 圖形名稱
    * Square
    * Rectangle
    * Triangle
    * Circle
* 圖形輸入需求
    * Square
        * 邊長
    * Rectangle
        * 長
        * 寬
    * Triangle
        * 邊長
        * 高
    * Circle
        * 半徑
##### 輸出: 每個圖形以 `(周長,面積)` 格式表示，當公式值相同時 ( 依順序: 正方形、長方形、三角形、圓形 )

### 第五週
#### 1. 使用 throw 與 IO 架構撰寫「檔案查詢程式」，透過輸入路徑及檔案名稱來查找相應之檔案是否存在該路徑底下。需確認此路徑是否正確，倘若無此路徑則需顯示「路徑錯誤，請重新輸入」，並重新輸入
##### 輸入: 絕對路徑 -> 檔案名稱
##### 輸出: 當輸入之絕對路徑存在時，輸出「請輸入欲查詢之檔案名稱」。當輸入之檔案存在，則顯示欲查詢檔案名稱；若不存在此檔案，則顯示絕對路徑下所有檔案名稱；若為空資料夾，則顯示「Empty」。

#### 2. 使用 ==delegate== 進行撰寫，給定預設陣列 {20, 45, 22, 39, 27} ，並透過 random 之方式產生一個有五個隨機整數的陣列，並將兩個陣列相加，再讓使用者輸入一個整數用以設定為次方數進行運算，最後由小到大進行排列。
##### 輸入: 次方
##### 輸出: 一個由小到大排序且擁有 5 個整數的陣列

#### 3. 使用 hash table 進行撰寫，給定一字串 licensePlate 以及另一個字串 words， 忽略 licensePlate 中的數字、空白，並將大小寫字母視為一致，例如，licensePlate = "aBc 12c"，則其包含字母 'a' 、 'b'、兩個的 'c'，請以 licensePlate 提供之條件找到 words 中最短的完成單字。須符合下列條件:
* 一個完成單字須包含 licensePlate 中的所有字母
* 如果字母在 licensePlate 中出現不只一次，則單字應含有相對等數量的該字母。
* 如果指定字母只出現一次，則單字也只能包含一個此字母。
* 如果不存在符合之單字，則輸出 "EOF" 。
* 如果有多個最短的單字，則回傳第一個出現於 words 中的。

##### 輸入: licensePlate、words (輸入十個單字，單字中間以空格隔開，單字皆為小寫)
##### 輸出: 最短的完成單字或 EOF 

### 第九週
#### 1. 透過 window form 製作出一個記憶翻牌遊戲，此遊戲會有 10 張牌，牌的初始化位置是隨機的，且每張牌都會有另外一張與之相同的牌。每輪玩家會翻開兩張牌，當兩張牌為一樣時，兩張牌以圖案那面顯示於原位上，反之，則翻開後重新覆蓋。最終玩家完成五組牌的配對後，遊戲結束。
* 介面示意圖:
![image](https://hackmd.io/_uploads/SJvWMOXqp.png)


## 期中上機考
[期中上機考](https://hackmd.io/@Y2000/HkNANL7qp)
## 期末上機考
[期末上機考](https://hackmd.io/@Y2000/HJSGBDmcp)