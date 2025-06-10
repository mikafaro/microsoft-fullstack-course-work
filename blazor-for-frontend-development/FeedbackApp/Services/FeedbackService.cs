public class FeedbackService
{
    private readonly List<Feedback> _feedbacks;

    public FeedbackService()
    {
        _feedbacks = new List<Feedback>();
    }

    public void AddFeedback(Feedback feedback)
    {
        if (feedback == null)
        {
            throw new ArgumentNullException(nameof(feedback), "Feedback cannot be null.");
        }

        _feedbacks.Add(feedback);
    }

    public IEnumerable<Feedback> GetAllFeedbacks()
    {
        return _feedbacks.AsReadOnly();
    }
}