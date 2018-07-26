
using System.ComponentModel.DataAnnotations;

namespace PFCharacterSheetEditor.Models
{
    public class CharacterSheet
    {
        [Required]
        public string CharacterName { get; set; }
        [Required]
        public int CharacterLevel { get; set; }
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

    }
}