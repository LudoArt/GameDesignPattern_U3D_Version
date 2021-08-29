# 原型模式

![image-20210829155155986](https://raw.githubusercontent.com/LudoArt/TyporaPictureBed/master/img/202009/image-20210829155155986.png)

由`SpawnerManager`统一管理，保存各种子类型的Monster生成器，通过函数`SpawnerMonster`生成指定类型和id的怪。

生成器中，通过调用特定类型的怪的`Clone`函数，生成同种类型的怪，通过id的形式生成不同个性的同种怪。

可以设置表格或者Json文件，如一个Goblin的表和一个Dragon的表，表里指定怪的id、名称、HP、出生点等不同的属性。在Goblin和Dragon的类中，初始化的时候去读取加载表格内容，缓存下来。（偷懒没做）