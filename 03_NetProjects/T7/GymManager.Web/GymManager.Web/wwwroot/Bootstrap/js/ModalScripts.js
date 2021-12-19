

var ModalMember = new bootstrap.Modal(document.getElementById('ModalMemberID'));
var btmOut = document.getElementById('BtnMemberOut');
var btmIn = document.getElementById('BtnMemberIn');

MemberUserID.onkeypress = function (e) {
    if (e.keyCode == 13) {
        StartModalMember();
    }
}



function StartModalMember() {
    var MemberID = document.getElementById('MemberUserID').value;
    var RegisterDate = moment(new Date()).format("HH:mm:ss");
    if (btmIn == null) {
        document.getElementById("ModalBody").innerHTML = "Member registered exit " + MemberID + " on " + RegisterDate;
    }
    else {
        document.getElementById("ModalBody").innerHTML = "Member registered entry " + MemberID + " on " + RegisterDate;
    }

    ModalMember.show();
    setTimeout(function () { ModalMember.hide(); }, 3000);

}



