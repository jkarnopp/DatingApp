var selectedId="",selectedUser=new Object;function saveUserInfo(){$("#usrname").val()&&($("#usrname").val()&&$.isEmptyObject(selectedUser)?$.when(getUserInfo().done(function(){$.isEmptyObject(selectedUser)||(console.log("after Save only:"+selectedUser.LanId),setValues())})):setValues())}function setValues(){console.log("After Ifs: "+selectedUser.LanId);getNamesWell(selectedUser);console.log(selectedId),$("#LanId").val(selectedUser.LanId),$("#FirstName").val(selectedUser.FirstName),$("#LastName").val(selectedUser.LastName),$("#Email").val(selectedUser.EmailAddress),clearUserInfo(),$("#idSearchModal").modal("hide")}function clearUserInfo(){$("#usrname").val(""),$("#LanIdDetails").html(""),selectedUser={}}function getUserInfo(){return $.ajax({url:window.baseUrl+"api/UserInformationsApi/GetByLanId?lanId="+$("#usrname").val(),type:"GET",dataType:"json",success:function(e){if(console.log(e),e.lanId){var s=getNamesWell(e);$("#LanIdDetails").html(s),selectedUser.LanId=e.lanId,selectedUser.FirstName=e.firstName,selectedUser.LastName=e.lastName,selectedUser.EmailAddress=e.emailAddress,console.log(window.selectedUser)}else $("#LanIdDetails").html("No User Found")},error:function(e,s,l){$("#LanIdDetails").html("No User Found"),console.log(l),console.log(s)}})}function getNamesWell(e){return"<br /><div class='card card-body bg-light'><ul><li><strong>LAN ID:</strong> "+e.lanId+"</li><li><strong>Name:</strong> "+e.firstName+" "+e.lastName+"</li><li><strong>Email:</strong> "+e.emailAddress+"</li></ul></div>"}function userInfoSuccess(e){var s=JSON.parse(e);$("#LanIdDetails").html("<ul><li>"+s.FirstName+"</li></ul>")}$(document).ready(function(){$("#editFormSubmit").click(function(){$("#editForm").submit()}),$("#LanId").on("focus",function(){$("#LanId").blur(),$("#idSearchModal").modal("show"),selectedId=this.id}),$("#idSearchModal").on("shown.bs.modal",function(){$("#usrname").focus()}),$("#checkUser").click(getUserInfo),$("#idSearchModalCancel").click(clearUserInfo),$("#saveUser").click(saveUserInfo),$("#sendToUser").click(function(){$("#IsSendToUser").val("True"),$("#notifyYesNoModal").modal("hide")}),$("#Enabled").change(function(){$(this).is(":checked")&&$("#notifyYesNoModal").modal("show")})});