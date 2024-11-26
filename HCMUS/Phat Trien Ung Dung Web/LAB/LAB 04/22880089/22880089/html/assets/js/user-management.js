document
  .querySelector("#editUserModal")
  .addEventListener("shown.bs.modal", () => {
    document.querySelector("#firstNameEdit").focus();
  });

document
  .querySelector("#addUserModal")
  .addEventListener("shown.bs.modal", () => {
    document.querySelector("#firstName").focus();
  });

document.querySelectorAll(".delete-btn").forEach((btnConfirm) => {
  btnConfirm.addEventListener("click", (e) => {
    let id = e.target.dataset.id;
    const options = {
      title: "Are you sure?",
      type: "danger",
      btnOkText: "Yes",
      btnCancelText: "No",
      onConfirm: () => {
        deleteUser(id);
      },
      onCancel: () => {
        console.log("Cancel");
      },
    };
    const {
      el,
      content,
      options: confirmedOptions,
    } = bs5dialog.confirm("Do you really want to delete this user?", options);
  });
});

async function deleteUser(id) {
  let res = await fetch(`/users/${id}`, {
    method: "DELETE",
  });
  location.reload();
}

function showUserData(e) {
  document.querySelector('#id').value = e.target.dataset.id;
  document.querySelector('#firstNameEdit').value = e.target.dataset.firstName;
  document.querySelector('#lastNameEdit').value = e.target.dataset.lastName;
  document.querySelector('#usernameEdit').value = e.target.dataset.username;
  document.querySelector('#mobileEdit').value = e.target.dataset.mobile;
  document.querySelector('#isAdminEdit').checked = e.target.dataset.isAdmin === 'true' ? true : false;
}

async function editUser(e) {
  e.preventDefault();
  let formData = new FormData(document.querySelector('#editUserForm'));
  let data = Object.fromEntries(formData.entries());

  let res = await fetch(`/users`, { 
    method: 'PUT', 
    body: JSON.stringify(data), 
    headers: { 'Content-Type': 'application/json' } 
  });
  location.reload();
}
