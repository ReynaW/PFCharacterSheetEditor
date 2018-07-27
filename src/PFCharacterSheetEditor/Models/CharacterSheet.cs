
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PFCharacterSheetEditor.Models
{
    public class CharacterSheet
    {
        public CharacterSheet()
        {
            ArmorClassItems = new List<ArmorClassItem>();
            Weapons = new List<Weapon>();
            SpecialAbilities = new List<SpecialAbility>();
            Feats = new List<Feat>();
            Items = new List<Item>();
            SpellsKnowns = new List<SpellsKnown>();
            SpellsPerDays = new List<SpellsPerDay>();
            SpellsKnownZeroLevels = new List<SpellsKnownZeroLevel>();
            SpellsKnownFirstLevels = new List<SpellsKnownFirstLevel>();
            SpellsKnownSecondLevels = new List<SpellsKnownSecondLevel>();
            SpellsKnownThirdLevels = new List<SpellsKnownThirdLevel> ();
            SpellsKnownFourthLevels = new List<SpellsKnownFourthLevel>();
            SpellsKnownFifthLevels = new List<SpellsKnownFifthLevel>();
            SpellsKnownSixthLevels = new List<SpellsKnownSixthLevel>();
            SpellsKnownSeventhLevels = new List<SpellsKnownSeventhLevel>();
            SpellsKnownEighthLevels = new List<SpellsKnownEighthLevel>();
            SpellsKnownNinthLevels = new List<SpellsKnownNinthLevel>();
            CharacterClasses = new List<CharacterClass>();
        }

        [Required]
        public string CharacterName { get; set; }
        [Required]
        public string CharacterClass { get; set; }
        [Required]
        public string Alignment { get; set; }
        public string PlayerName { get; set; }
        public string Deity { get; set; }
        public string Homeland { get; set; }
        [Required]
        public string Race { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public char Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        [Required]
        public int BaseSpeed { get; set; }
        [Required]
        public int BaseSpeedWithArmor { get; set; }
        public int BaseFlySpeed { get; set; }
        public string FlyManuverability { get; set; }
        public int BaseSwimSpeed { get; set; }
        public int BaseClimbSpeed { get; set; }
        public int BaseBurrowSpeed { get; set; }
        public bool ClassSkillAcrobatics { get; set; }
        public bool ClassSkillAppraise { get; set; }
        public bool ClassSkillBluff { get; set; }
        public bool ClassSkillCraft { get; set; }
        public bool ClassSkillClimb { get; set; }
        public bool ClassSkillDiplomacy { get; set; }
        public bool ClassSkillDisableDevice { get; set; }
        public bool ClassSkillDisguise { get; set; }
        public bool ClassSkillEscapeArtist { get; set; }
        public bool ClassSkillFly { get; set; }
        public bool ClassSkillHandleAnimal { get; set; }
        public bool ClassSkillHeal { get; set; }
        public bool ClassSkillIntimidate { get; set; }
        public bool ClassSkillKnowledgeArcana { get; set; }
        public bool ClassSkillKnowledgeDungeoneering { get; set; }
        public bool ClassSkillKnowledgeEngineering { get; set; }
        public bool ClassSkillKnowledgeGeography { get; set; }
        public bool ClassSkillKnowledgeHistory { get; set; }
        public bool ClassSkillKnowledgeLocal { get; set; }
        public bool ClassSkillKnowledgeNature { get; set; }
        public bool ClassSkillKnowledgeNobility { get; set; }
        public bool ClassSkillKnowledgePlanes { get; set; }
        public bool ClassSkillKnowledgeReligion { get; set; }
        public bool ClassSkillLingusitics { get; set; }
        public bool ClassSkillPerception { get; set; }
        public bool ClassSkillPerform { get; set; }
        public bool ClassSkillProfession { get; set; }
        public bool ClassSkillRide { get; set; }
        public bool ClassSkillSenseMotive { get; set; }
        public bool ClassSkillSleightOfHand { get; set; }
        public bool ClassSkillSpellcraft { get; set; }
        public bool ClassSkillStealth { get; set; }
        public bool ClassSkillSurvival { get; set; }
        public bool ClassSkillSwim { get; set; }
        public bool ClassSkillUseMagicDevice { get; set; }
        [Required]
        public int StrengthScore { get; set; }
        [Required]
        public int DexterityScore { get; set; }
        [Required]
        public int ConstitutionScore { get; set; }
        [Required]
        public int IntelligenceScore { get; set; }
        [Required]
        public int WisdomScore { get; set; }
        [Required]
        public int CharismaScore { get; set; }
        [Required]
        public int BaseAttackBonus { get; set; }
        [Required]
        public int BaseFortitudeSave { get; set; }
        [Required]
        public int BaseReflexSave { get; set; }
        [Required]
        public int BaseWillSave { get; set; }
        public int SpelResistance { get; set; }
        public int ArmorBonus { get; set; }
        public int ShieldBonus { get; set; }
        public int NaturalArmor { get; set; }
        public int DeflectionBonus { get; set; }
        public int MiscACBonus { get; set; }
        public int MiscInitBonus { get; set; }
        public int DamageResistance { get; set; }
        public string DomainSpecialty { get; set; }
        public int PlayerCP { get; set; }
        public int PlayerSP { get; set; }
        public int PlayerGP { get; set; }
        public int PlayerPP { get; set; }
        public string ConditionalModifiers { get; set; }
        public string Languages { get; set; }
        public int PlayerExp { get; set; }
        public int PlayerExpNextLevel { get; set; }
        public int DamageResistanceValue { get; set; }
        public string DamageResistanceType { get; set; }

        public List<ArmorClassItem> ArmorClassItems { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<SpecialAbility> SpecialAbilities { get; set; }
        public List<Feat> Feats { get; set; }
        public List<Item> Items { get; set; }
        public List<SpellsKnown> SpellsKnowns { get; set; }
        public List<SpellsPerDay> SpellsPerDays { get; set; }
        public List<SpellsKnownZeroLevel> SpellsKnownZeroLevels { get; set; }
        public List<SpellsKnownFirstLevel> SpellsKnownFirstLevels { get; set; }
        public List<SpellsKnownSecondLevel> SpellsKnownSecondLevels { get; set; }
        public List<SpellsKnownThirdLevel> SpellsKnownThirdLevels { get; set; }
        public List<SpellsKnownFourthLevel> SpellsKnownFourthLevels { get; set; }
        public List<SpellsKnownFifthLevel> SpellsKnownFifthLevels { get; set; }
        public List<SpellsKnownSixthLevel> SpellsKnownSixthLevels { get; set; }
        public List<SpellsKnownSeventhLevel> SpellsKnownSeventhLevels { get; set; }
        public List<SpellsKnownEighthLevel> SpellsKnownEighthLevels { get; set; }
        public List<SpellsKnownNinthLevel> SpellsKnownNinthLevels { get; set; }
        public List<CharacterClass> CharacterClasses { get; set; }
    }

    public class ArmorClassItem
    {
        public string ACItem { get; set; }
        public int Bonus { get; set; }
        public string ArmorType { get; set; }
        public int CheckPenalty { get; set; }
        public int SpellFaliure { get; set; }
        public int Weight { get; set; }
        public string Property { get; set; }
    }
    public class Weapon
    {
        public string PlayerWeapon { get; set; }
        public string AttackBonus { get; set; }
        public string Critical { get; set; }
        public string WeaponType { get; set; }
        public string Range { get; set; }
        public string Ammunition { get; set; }
        public string Damage { get; set; }
    }
    public class SpecialAbility
    {
        public string PlayerSpecialAbility { get; set; }
    }
    public class Feat
    {
        public string PlayerFeat { get; set; }
    }
    public class Item
    {
        public string ItemName { get; set; }
        public int ItemWeight { get; set; }
    }
    public class SpellsKnown
    {
        public int SpellsKnown0 { get; set; }
        public int SpellsKnown1 { get; set; }
        public int SpellsKnown2 { get; set; }
        public int SpellsKnown3 { get; set; }
        public int SpellsKnown4 { get; set; }
        public int SpellsKnown5 { get; set; }
        public int SpellsKnown6 { get; set; }
        public int SpellsKnown7 { get; set; }
        public int SpellsKnown8 { get; set; }
        public int SpellsKnown9 { get; set; }

    }
    public class SpellsPerDay
    {
        public int SpellsPerDay0 { get; set; }
        public int SpellsPerDay1 { get; set; }
        public int SpellsPerDay2 { get; set; }
        public int SpellsPerDay3 { get; set; }
        public int SpellsPerDay4 { get; set; }
        public int SpellsPerDay5 { get; set; }
        public int SpellsPerDay6 { get; set; }
        public int SpellsPerDay7 { get; set; }
        public int SpellsPerDay8 { get; set; }
        public int SpellsPerDay9 { get; set; }
    }
    public class SpellsKnownZeroLevel
    {
        public string Spell1ZeroLevel { get; set; }
        public string Spell2ZeroLevel { get; set; }
        public string Spell3ZeroLevel { get; set; }
        public string Spell4ZeroLevel { get; set; }
        public string Spell5ZeroLevel { get; set; }
        public string Spell6ZeroLevel { get; set; }
        public string Spell7ZeroLevel { get; set; }
        public string Spell8ZeroLevel { get; set; }
    }
    public class SpellsKnownFirstLevel
    {
        public string Spell1FirstLevel { get; set; }
        public string Spell2FirstLevel { get; set; }
        public string Spell3FirstLevel { get; set; }
        public string Spell4FirstLevel { get; set; }
        public string Spell5FirstLevel { get; set; }
        public string Spell6FirstLevel { get; set; }
        public string Spell7FirstLevel { get; set; }
        public string Spell8FirstLevel { get; set; }
    }
    public class SpellsKnownSecondLevel
    {
        public string Spell1SecondLevel { get; set; }
        public string Spell2SecondLevel { get; set; }
        public string Spell3SecondLevel { get; set; }
        public string Spell4SecondLevel { get; set; }
        public string Spell5SecondLevel { get; set; }
        public string Spell6SecondLevel { get; set; }
        public string Spell7SecondLevel { get; set; }
    }
    public class SpellsKnownThirdLevel
    {
        public string Spell1ThirdLevel { get; set; }
        public string Spell2ThirdLevel { get; set; }
        public string Spell3ThirdLevel { get; set; }
        public string Spell4ThirdLevel { get; set; }
        public string Spell5ThirdLevel { get; set; }
        public string Spell6ThirdLevel { get; set; }

    }
    public class SpellsKnownFourthLevel
    {
        public string Spell1FourthLevel { get; set; }
        public string Spell2FourthLevel { get; set; }
        public string Spell3FourthLevel { get; set; }
        public string Spell4FourthLevel { get; set; }
        public string Spell5FourthLevel { get; set; }

    }
    public class SpellsKnownFifthLevel
    {
        public string Spell1FifthLevel { get; set; }
        public string Spell2FifthLevel { get; set; }
        public string Spell3FifthLevel { get; set; }
        public string Spell4FifthLevel { get; set; }

    }
    public class SpellsKnownSixthLevel
    {
        public string Spell1SixthLevel { get; set; }
        public string Spell2SixthLevel { get; set; }
        public string Spell3SixthLevel { get; set; }
        public string Spell4SixthLevel { get; set; }

    }
    public class SpellsKnownSeventhLevel
    {
        public string Spell1SeventhLevel { get; set; }
        public string Spell2SeventhLevel { get; set; }
        public string Spell3SeventhLevel { get; set; }
        public string Spell4SeventhLevel { get; set; }

    }
    public class SpellsKnownEighthLevel
    {
        public string Spell1EighthLevel { get; set; }
        public string Spell2EighthLevel { get; set; }
        public string Spell3EighthLevel { get; set; }

    }
    public class SpellsKnownNinthLevel
    {
        public string Spell1NinthLevel { get; set; }
        public string Spell2NinthLevel { get; set; }

    }
    public class CharacterClass
    {
        public string PlayerCharacterClass { get; set; }
        public int ClassLevel { get; set; }
    }
}