
namespace MonsterHunterDLL.Classes
{
    public interface IPlayerStates
    {
        #region Methods
        //Method to set hunter stats depending on state
        void SetHunterStats (Hunter hunter);

        //Method to calculate damage in combat
        float CalculateDamage (Hunter hunter, int swordDmg);

        //Method to calculate defense in combat
        float CalculateDefense (Hunter hunter, int shieldDefense);
        #endregion
    }
}
