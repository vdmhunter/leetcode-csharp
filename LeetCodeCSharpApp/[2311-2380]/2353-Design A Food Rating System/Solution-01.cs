namespace LeetCodeCSharpApp.DesignAFoodRatingSystem01;

public class FoodRatings
{
    private readonly Dictionary<string, (int negativeOfRating, string cuisine)> _foodToRatingAndCuisine = new();
    private readonly Dictionary<string, SortedSet<(int negativeOfRating, string food)>> _cuisineToSortedFoods = new();

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
    {
        for (var i = 0; i < foods.Length; ++i)
        {
            _foodToRatingAndCuisine[foods[i]] = (-ratings[i], cuisines[i]);

            _cuisineToSortedFoods.TryAdd(cuisines[i], new SortedSet<(int negativeOfRating, string food)>());
            _cuisineToSortedFoods[cuisines[i]].Add((-ratings[i], foods[i]));
        }
    }

    public void ChangeRating(string food, int newRating)
    {
        var (negativeOfOldRating, cuisine) = _foodToRatingAndCuisine[food];
        var set = _cuisineToSortedFoods[cuisine];

        set.Remove((negativeOfOldRating, food));
        set.Add((-newRating, food));

        _foodToRatingAndCuisine[food] = (-newRating, cuisine);
    }

    public string HighestRated(string cuisine)
    {
        return _cuisineToSortedFoods[cuisine].Min.food;
    }
}
