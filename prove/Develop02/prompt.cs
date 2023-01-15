class prompt{
    void Load(){
        try{
            string[] lines = System.IO.File.ReadAllLines(_file);
            foreach (string line in lines){
                _prompts.Add(line);
            }
        }catch (FileNotFoundException e){
            using (StreamWriter outputFile = new StreamWriter(_file)){
                outputFile.WriteLine("What will be my first thing to do on this day?");
                outputFile.WriteLine("Which scripture keeps me lifted while reading scriptures?")
                outputFile.WriteLine("How can I seek the guidance of my Heavenly Father?")
            }
        }
    }
}

