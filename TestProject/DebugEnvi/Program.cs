string ipAddress = "255.120.201.0256";

string[] splitted  = ipAddress.Split(".");
int[] converted = new int[4];

int error = 0; 
for(int i=0; i<splitted.Length; i++){
    converted[i] = int.Parse(splitted[i]);
    Console.WriteLine($"{converted[i]}: {ValidateLength(splitted[i])}: {ValidateRange(splitted[i])}");
    
    if(!(ValidateLength(splitted[i]) && ValidateRange(splitted[i]))){
        error ++;
    }
}

if(error != 0){
    Console.WriteLine($"Invalid IpV4 ({error}) error detected");
}else{
    Console.WriteLine("Ip is valid IpV4");
}

static bool ValidateLength(string value){
    char[] data = value.ToCharArray();
    int dataNum = data.Length;

    return (dataNum <5 ? true: false);
}

static bool ValidateRange(string value){
    int converted = int.Parse(value);
   
   return (converted<256 ? true: false);
}