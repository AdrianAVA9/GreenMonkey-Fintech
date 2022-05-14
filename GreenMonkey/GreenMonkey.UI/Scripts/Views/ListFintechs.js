function ListFintechs(){
    this.tblFintechs = 'tblListFintechs';
    this.service = 'suscriptors';
    this.columns = "Code,Name,Owner";
    this.ctrlActions = new ControlActions();

    this.RetrieveAllFintechs = function () {
        console.log("Init");
        //this.ctrlActions.FillTable(this.service, this.tblFintechs, false);
    };

    this.selectRow = function (data){
        console.log(data);
    }

    this.createAccount = function () {
        let customer = this.ctrlActions.GetDataForm("customer-form");
        console.log(customer);
    }

    this.clearForm = function () {
        console.log("Clear form");
    }
};

$(document).ready(function () {
    let fintechs = new ListFintechs();
    fintechs.RetrieveAllFintechs();
});