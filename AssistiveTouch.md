# AssistiveTouch

> [演练：创建你的第一个触控应用程序](https://docs.microsoft.com/zh-cn/dotnet/desktop/wpf/advanced/walkthrough-creating-your-first-touch-application?view=netframeworkdesktop-4.8)  
> [学习WPF -- 解决方案项目结构](https://zhuanlan.zhihu.com/p/113175395)

首先使用`<Ellipse x:Name="round" Width="200" Height="200" Fill="AliceBlue"/>`构造出圆形移动块。

再根据[演练：创建你的第一个触控应用程序](https://docs.microsoft.com/zh-cn/dotnet/desktop/wpf/advanced/walkthrough-creating-your-first-touch-application?view=netframeworkdesktop-4.8)赋予触控移动。

再给出TouchUp事件的函数，使得圆形移动块恢复原位。

整了好久结果WPF好像不好写。

[Washington.edu](https://assab.cs.washington.edu/svn/prototypes/MultiTouchGestureTest01/MultiTouchGestureTest01/Form1.cs)

[stackoverflow](https://stackoverflow.com/questions/35360024/touch-scrolling-for-winforms-in-c-sharp)

现在的情况是，Gesture事件已经可以正常用了。但是不好实现“判断手势结束”

经过测试，无论是有多快的速度来滑动，Gesture事件都会测出GestureEventArgs(0,0)

GestureId好像可以用？？

好像有的解了，放弃使用GID_PAN，而值用GID_END，这会没法获取实时的滑动信息，只得到初始和结束时的坐标。

具体操作就是把case: GID_PAN里的操作移到GID_END里，并注释掉GID_PAN的`this.OnGesture(ea);`

事实上直接用GID_PAN里的代码不太好，它好像会计算加速度，使得在滑动过快时delay有些严重。

接下来就只要简化代码了，里面还有挺多不了解的。

