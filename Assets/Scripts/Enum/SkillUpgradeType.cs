public enum SkillUpgradeType
{
    None,

    // ------ Dash Tree -------
    Dash, // 闪避伤害
    Dash_CloneOnStart, // 闪避开始时创建一个分身
    Dash_CloneOnStartAndArrival, // 闪避开始和结束时分别创建一个分身
    Dash_ShardOnStart, // 闪避开始时创建一个碎片 Dash_ShardOnShart
    Dash_ShardOnStartAndArrival, // 闪避开始和结束时分别创建一个碎片

    // ------ Shard Tree -------
    Shard, // 碎片在被敌人触碰或时间到期时爆炸
    Shard_MoveToEnemy, // 碎片会移动到最近的敌人
    Shard_Multicast, // 碎片技能可以拥有最多N个充能，可以一次性释放所有充能
    Shard_Teleport, // 可以与你最后创建的碎片交换位置
    Shard_TeleportHpRewind, // 与碎片交换位置时，你的生命值会回溯到创建碎片时的百分比

    // ------ SwordThrow Tree -------
    SwordThrow, // 可以投掷剑对远程敌人造成伤害
    SwordThrow_Spin, // 剑会在一点旋转并攻击敌人，像电锯一样
    SwordThrow_Pierce, // 穿透剑可以攻击N个目标
    SwordThrow_Bounce, // 弹跳剑会在敌人之间弹跳

    // ------ Time Echo Tree -------
    TimeEcho,  // 创建一个可以被敌人攻击的玩家分身
    TimeEcho_SingleAttack, // 时间回响可以进行一次攻击
    TimeEcho_MultiAttack, // 时间回响可以进行N次攻击
    TimeEcho_ChanceToDuplicate, // 时间回响在攻击时有几率创建另一个时间回响

    TimeEcho_HealWisp, // 当时间回响死亡时，会生成一个飞向玩家的治疗精灵
                       // 治疗量等于死亡时所承受伤害的百分比
    TimeEcho_CleanseWisp, // 治疗精灵会移除玩家身上的负面效果
    TimeEcho_CooldownWisp, // 治疗精灵会减少所有技能的冷却时间N秒

    // ------ Domain Expansion -------
    Domain_SlowingDown, // 创建一个可以减缓敌人速度90-100%的区域，你可以在其中自由移动和战斗
    Domain_EchoSpam, // 你将无法移动，但可以使用时间回响技能不断攻击敌人
    Domain_ShardSpam // 你将无法移动，但可以使用碎片技能不断攻击敌人 Dash_ShardOnShart
}
