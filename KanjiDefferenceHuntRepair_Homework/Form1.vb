Public Class FormGame
    Dim correctText As String = "荻"                  '正解の文字：1つだけ
    Dim mistakeText As String = "萩"                  '間違いの文字：24個分
    Dim nowTime As Double                             '経過時間
    Dim shortestTime As Double = Double.MaxValue      '最短クリア時間（初期値として最大値を入れる）
    Dim previousTime As Double                        '前回クリア時間

    '画面下部の25個のボタンのいずれかをクリックしたとき（共通で呼ばれる）
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click,
                                                                        Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click,
                                                                        Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click,
                                                                        Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click,
                                                                        Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click
        'クリックしたボタンのテキストは正解の文字か？
        '正解の場合
        If CType(sender, Button).Text = correctText Then
            Timer1.Stop()                       'タイマーをストップ

            '最短クリア時間が更新される場合
            If nowTime < shortestTime Then
                shortestTime = nowTime          '最短クリア時間を更新
            End If
            'メッセージを表示
            MessageBox.Show("最短クリア時間：" & shortestTime.ToString("0.00") &
                            vbCrLf &
                            "前回クリア時間：" & previousTime.ToString("0.00"))

            previousTime = nowTime              '前回クリア時間を更新
        Else
            '間違いの場合
            'ペナルティ10秒追加する
            nowTime = nowTime + 10
        End If
    End Sub

    'スタートボタンをクリックした時
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        TextHunt.Text = correctText                     '正解の文字を表示する

        Dim Rnd As New Random()         　　　　　　　　'乱数を生成する為のインスタンスを生成
        Dim randomResult As Integer = Rnd.Next(25)      '0～24の乱数を取得する

        'SplitContainerの下部のPanel2に乗っている
        'ButtonのTextを全て間違いの文字にする
        For i = 0 To SplitContainer1.Panel2.Controls.Count - 1
            '画面下部のButtonのTextを一旦全て失敗の文字にする
            SplitContainer1.Panel2.Controls(i).Text = mistakeText
        Next
        'ランダムで1つだけ正解の文字にする
        SplitContainer1.Panel2.Controls(randomResult).Text = correctText

        'タイマースタート
        nowTime = 0          '初期化
        Timer1.Start()
    End Sub

    '0.02秒おきに呼ばれるタイマーのイベントハンドラ
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '今の時間に0.02秒を追加する
        nowTime = nowTime + 0.02
        'Textに今の時間を表示する
        TextTimer.Text = nowTime.ToString("0.00")
    End Sub
End Class
