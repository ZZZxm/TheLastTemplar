# The Last Templar

## 游戏简介
...
## 游戏背景
宇航员 外星生物
## 游戏类型
* 2D 
* Rougelike
## 适用平台
* Windows
* MacOS

## 游戏玩法
1. 选择角色
2. WASD控制角色移动，右键攻击，QE特殊技能
3. 每个Journey包含9个随机关卡
4. 每个随机关卡需完成随机任务
5. 道具能增加玩家HP,MP等

## 操作说明
| Keyboard/Mouse | Game |
| -------- | ------- |
|   <kbd>↑</kbd>/<kbd>W</kbd> | 上    
|   <kbd>↓</kbd>/<kbd>S</kbd> | 下    
|   <kbd>←</kbd>/<kbd>A</kbd> | 左    
|   <kbd>→</kbd>/<kbd>D</kbd> | 右   
| 鼠标右键| 攻击
|   <kbd>Q</kbd>     | 技能1    
|   <kbd>E</kbd>     | 技能2     
|   <kbd>SPACE</kbd>     | 闪避 


Player1太空武士：

|Attack| Effect|
|---|---|
|普通攻击 |一刀扣去敌人200点血量
|技能Q|攻击2秒内攻击力倍增
|技能E|1秒内速度倍增

Player2太空射手:

|Attack| Effect|
|---|---|
|普通攻击 |向面前发射普通子弹
|技能Q|向面前发射加大子弹，可以直接打死一个小怪
|技能E|向面前110&deg;方向内发射12颗子弹

Player3太空炸弹人：

|Attack| Effect|
|---|---|
|普通攻击 |范围为1的十字形炸弹 有1.5秒的冷却时间
|技能Q|增加攻击范围为3
|技能E|2秒内消除冷却时间限制


## 功能实现

- [x] 支持背包系统（玩家可切换装备）
- [x] 支持道具系统（回血道具、回蓝道具、加速道具、加防道具）
- [x] 支持四种随机关卡模式（击败所有敌人、幸存模式、宝箱模式、Boss战）
- [x] 支持三种人物选择(近战, 射击, 炸弹)
- [x] 支持三种敌人（Flying Monster, Green Monster, Boss）
- [x] 支持敌人自动追踪玩家
- [x] 支持四种敌人生成机制（根据随机关卡而改变）

## 开发环境

* Unity 2019.4.22

## 游戏设计


### 玩家设计
**Player1近战砍刀**

![](docpic/player1.png)

|攻击| 效果|
|---|---|
|普通攻击 |一刀扣去敌人200点血量
|技能Q|攻击2秒内攻击力倍增
|技能E|1秒内速度倍增

|属性|设置|
|---|---|
|生命值|初始值500|
|技能值|初始值200，技能Q消耗3点蓝，技能E消耗5点蓝|
|速度|初始值10

**Player2远程射击**

![](docpic/player2.png)

|攻击| 效果|
|---|---|
|普通攻击 |发射小子弹，攻击力为100
|技能Q|发射大子弹，怪物直接死亡
|技能E|发射多方向子弹

|属性|设置|
|---|---|
|生命值|初始值300|
|技能值|初始值250，技能Q消耗3点蓝，技能E消耗5点蓝|
|速度|初始值10

**Player3炸弹人**

![](docpic/player3.png)

|攻击| 效果|
|---|---|
|普通攻击 |范围为1的十字形无差别攻击炸弹，攻击力为50，有1.5秒的冷却时间
|技能Q|增加攻击范围为3
|技能E|2秒内消除冷却时间限制

|属性|设置|
|---|---|
|生命值|初始值400|
|技能值|初始值150，技能Q消耗5点蓝，技能E消耗3点蓝|
|速度|初始值10


### 敌人设计
|怪物种类| UI |攻击力|备注|
|---|---|---|---|
|Flying Monster|
|Green Monster|
|Boss|

### 地图设计
贴图

### 关卡设计


### 道具设计
|道具类型|UI|效果|数量|备注|
|---|---|---|---|---|

### 逻辑设计
流程图


## 项目文件结构

## 游戏开发



## 小组成员分工

| 学号    | 姓名     | 分工                                       |
| ------- | -------- | ------------------------------------------ |
| 1751551 | 黄颖    |玩家1&玩家3动画制作、动画自动机设计、攻击实现|                                            |
| 1753307 | 蔡方俊妍 |                                            |
| 1850250 | 赵浠明   | 敌人动画制作、敌人AI实现、敌人生成机制实现 |
| 1852137 | 张艺腾   |                                            |
| 1853829 | 杨雨辰   |                                            |

