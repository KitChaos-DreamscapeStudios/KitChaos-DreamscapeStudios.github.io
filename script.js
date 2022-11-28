
function PrintData(){
    
    let dataBase = fetch('./Base.json');
    let data = dataBase.then((response) => response.json());
    //Access some data \|/
    data.then((entry) => console.log(entry.e.id))
    
    
}

