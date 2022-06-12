namespace unit04_Greed.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>
    public class Artifact : Actor
    {
        private int score = 0;

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public Artifact()
        {

        }

        /// <summary>
        /// Gets the artifact's score.
        /// </summary>
        /// <returns>The score</returns>
        public int GetScore()
        {
            return score;
        }

        /// <summary>
        /// Sets the artifact's value to the .
        /// </summary>
        /// <param name="Score">The score of the object.</param>
        public void SetScore(int score)
        {
            this.score = score;
        }
    }
}