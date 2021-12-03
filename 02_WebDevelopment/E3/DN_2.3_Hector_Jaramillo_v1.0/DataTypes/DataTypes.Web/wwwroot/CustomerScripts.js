

class Customer {
    constructor(Name, RegisterDate) {
        this.Name = Name;
        this.RegisterDate = RegisterDate;
    }
}

var CustomerParameter = document.getElementById("CustomerList");

var CustomerList = new Array();
CustomerList.push(new Customer("Edy", new Date(2021, 10, 11)));
CustomerList.push(new Customer("Jesus", new Date(2021, 12, 1)));
CustomerList.push(new Customer("Manuel", new Date(2021, 10, 10)));
CustomerList.push(new Customer("Alejandra", new Date(2021, 7, 3)));
CustomerList.push(new Customer("Roberto", new Date(2021, 9, 1)));
CustomerList.push(new Customer("Sofia", new Date(2021, 2, 6)));
CustomerList.push(new Customer("Fernanda", new Date(2021, 7, 1)));
CustomerList.push(new Customer("Dulce", new Date(2021, 4, 30)));
CustomerList.push(new Customer("Jazmin", new Date(2021, 1, 22)));
CustomerList.push(new Customer("Nelly", new Date(2021, 2, 21)));

var ul = "<ul>";

for (var i = 0; i < CustomerList.length; i++) {
    ul += ("<li>" + "Client: " + CustomerList[i].Name + " Register Date: " + moment(CustomerList[i].RegisterDate).format("DD-MM-YYYY HH:MM") + "</li>");
}

ul += "</ul>";

CustomerParameter.innerHTML = ul;