# TimerTest
比較 C# Timer 與 Wmm Timer 精準度

C# 裡有三種 Timer

（1）定義在System.Windows.Forms

（2）定義在System.Threading.Timer

（3）定義在System.Timers.Timer

因為系統限制, 所以精度會在 15.625ms。

在進行媒體播放、繪製動畫、效能分析以及和硬體互動時有可能會不夠精準，在此情況下可以調用 Wmm 的 Timer 來達到 1ms 的精準度。

