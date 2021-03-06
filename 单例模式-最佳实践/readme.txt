﻿主要意图：保证一个类仅有一个实例，并提供一个访问它的全局访问点。 主要解决：一个全局使用的类频繁地创建与销毁。 何时使用：当您想控制实例数目，节省系统资源的时候。 使用场景：

要求生产唯一序列号；
WEB 中的计数器，不用每次刷新都在数据库里加一次，用单例先缓存起来；
创建的一个对象需要消耗的资源过多，比如 I/O 与数据库的连接等；
全局配置文件访问，单例类来保证数据唯一性；
日志记录帮助类，为节省资源，全局一个实例一般就够了；
桌面应用常常要求只能打开一个程序实例或一个窗口。