# 命令模式

主要做了两个功能，一个是角色的移动，简单做了左右移动和跳跃三个指令；另一个是三个指令的自定义按键。

直接上图（感谢VS自带的查看类图工具）：

![image-20200912174049174](https://raw.githubusercontent.com/LudoArt/TyporaPictureBed/master/image-20200912174049174.png)

一个`Command`抽象类，有一个`Execute`方法，多个具体的指令类，执行相应的操作。

![image-20200912174210400](https://raw.githubusercontent.com/LudoArt/TyporaPictureBed/master/image-20200912174210400.png)

一个`CommandManager`，集中在`Update`中处理各个指令，只需要更改变量`LEFT`，`RIGHT`，`JUMP` 就可以实现自定义按键（实质是将输入与要做的事情用一个“指针”联系起来）。此外，在方法`Execute`中传入player作为参数，意味着可以通过修改传入的参数控制不同的物体，如玩家2，AI等。

另一个好处是可以在`CommandManager`中预留一个数组，将每次新建的指令压入数组，这样就可以实现一个“撤销和重做”的功能（很可惜在本项目中没有体现，因为对player的移动是靠给刚体施加力来完成的，“撤销”的话player的位置感觉不太好处理就没做了，暂时的思路是可以在每次指令执行的时候把当前帧的player所在的位置信息记录下来，这样或许可以实现“撤销”功能，先挖个坑以后再填）。

> Unity自定义输入参考资料：https://www.studica.com/blog/custom-input-manager-unity-tutorial
