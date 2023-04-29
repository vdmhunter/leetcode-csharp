namespace LeetCodeCSharpApp.MinimumHoursOfTrainingToWinACompetition01;

public class Solution
{
    public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
    {
        var currentEnergy = initialEnergy;
        var currentExperience = initialExperience;
        var totalHours = 0;

        for (var i = 0; i < energy.Length; i++)
        {
            if (currentEnergy <= energy[i])
            {
                var hours = energy[i] - currentEnergy + 1;
                totalHours += hours;
                currentEnergy += hours;
            }

            currentEnergy -= energy[i];
        }

        for (var i = 0; i < experience.Length; i++)
        {
            if (currentExperience <= experience[i])
            {
                var hours = experience[i] - currentExperience + 1;
                totalHours += hours;
                currentExperience += hours;
            }

            currentExperience += experience[i];
        }

        return totalHours;
    }
}
