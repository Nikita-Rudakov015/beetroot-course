document.addEventListener("DOMContentLoaded", function(){
    document.forms.register.addEventListener("submit", function(){
        var formData = new FormData(this);
        var userData = {
            login: formData.get("login"),
            password: formData.get("p1"),
            name: formData.get("name")
        }
        console.log(userData);
    });
});
