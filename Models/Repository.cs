namespace PartyInvite.Models
{
    public static class Repository
    {
        private static List<Response> _responses = new();
        public static IEnumerable<Response> Responses => _responses;

        public static void AddResponse(Response response)
        {
            Console.WriteLine(response);
            _responses.Add(response);
        }
    }
}
