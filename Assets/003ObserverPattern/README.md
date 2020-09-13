# 观察者模式

利用观察者模式主要做了一个功能，当按下`ESC`键后弹出标题，此时游戏暂停，且切换背景音乐。

![image-20200913143800971](https://raw.githubusercontent.com/LudoArt/TyporaPictureBed/master/img/202009/image-20200913143800971.png)

观察者主要有两个，`GMObserver`和`SMObserver`，第一个负责监听事件并管理游戏暂停与运行，第二个负责背景音乐的切换。

![image-20200913144216887](https://raw.githubusercontent.com/LudoArt/TyporaPictureBed/master/img/202009/image-20200913144216887.png)

被观察者主要有添加/移除观察者的功能和通知的功能。

> 在Unity+C#中，这种实现方式感觉并不完美，仅作为一种练习。Unity和C#中的事件系统其实就是一个完整的观察者模式了。