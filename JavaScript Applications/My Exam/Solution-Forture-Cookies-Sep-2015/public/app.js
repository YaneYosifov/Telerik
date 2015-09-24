(function() {

  var sammyApp = Sammy('#content', function() {

    this.get('#/', homeController.all);

    this.get('#/cookies', cookiesController.all);
    this.get('#/cookies/add', cookiesController.add);

    this.get('#/my-cookie', eventsController.all);
    this.get('#/my-cookie/add', eventsController.add);

    this.get('#/users', usersController.all);
    this.get('#/users/register', usersController.register);

    this.get('#/categories', categoriesController.all);
  });

  $(function() {
    sammyApp.run('#/user');

    if (data.users.hasUser()) {
      $('#container-sign-in').addClass('hidden');
      $('#btn-sign-out').on('click', function() {
        data.users.signOut()
          .then(function() {
            document.location = '#/';
            document.location.reload(true);
          });
      });
    } else {
      $('#container-sign-out').addClass('hidden');
      $('#btn-sign-in').on('click', function(e) {
      	e.preventDefault();
        var user = {
          username: $('#tb-username').val(),
          password: $('#tb-password').val()
        };
        data.users.signIn(user)
          .then(function(user) {
            document.location = '#/';
            document.location.reload(true);
          }, function(err) {
            $('#container-sign-in').trigger("reset");
            toastr.error(err.responseText);
          });
      });
    }
  });
}());
