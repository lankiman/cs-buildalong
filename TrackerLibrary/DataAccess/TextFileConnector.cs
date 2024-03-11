using System;


namespace TrackerLibrary
{
    public class TextFileConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }
    }
}