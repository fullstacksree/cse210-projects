class prompt{
    void Load(){
        try{
            string[] lines = System.IO.File.ReadAllLines(_file);
            foreach (string line in lines){
                _prompt.Add(line);
            }
        }catch (FileNotFoundException){
            using (StreamWriter outputFile = new StreamWriter(_file))
            {
                outputFile.WriteLine("What will be my first thing to do on this day?");
                outputFile.WriteLine("Which scripture keeps me lifted while reading?");
                outputFile.WriteLine("How can I seek the guidance of my Heavenly Father?");
            }
        }
    }
}

