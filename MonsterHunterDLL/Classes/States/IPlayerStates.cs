
namespace MonsterHunterDLL.Classes
{
    public interface IPlayerStates
    {
        #region Methods
        //Method to set pHhunter stats depending on state
        void SetHunterStats (Hunter pHhunter);

        //Method to calculate damage in combat
        float CalculateDamage (Hunter pHhunter, int piSwordDmg);

        //Method to calculate fDefense in combat
        float CalculateDefense (Hunter pHhunter, int piShieldDefense);
        #endregion
    }
}
