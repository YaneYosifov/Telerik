var cookiesController = (function() {

  function all(context) {
    var cookies;
    var category = context.params.category || null;
    data.cookies.get()
      .then(function(resCookies) {
        cookies = _.chain(resCookies)
          .groupBy(controllerHelpers.groupByCategory)
          .map(controllerHelpers.parseGroups).value();

        if (category) {
          cookies = cookies.filter(controllerHelpers.filterByCategory(category));
        }

        return templates.get('cookies');
      })
      .then(function(template) {
        context.$element().html(template(cookies));

        $('.cookie-box').on('change', function() {
          var $checkbox = $(this).find('input');
          var isChecked = $checkbox.prop('checked');
          var id = $(this).attr('data-id');
          data.cookies.update(id, {
            state: isChecked
          }).then(function(cookie) {
            toastr.clear();
            toastr.error(`Cookie ${cookie.text} updated!`);
          });
        });
      })
      .catch(function(err) {
        console.log(err);
      });
  }

  function add(context) {
    templates.get('cookie-add')
      .then(function(template) {
        context.$element()
          .html(template());
        return data.categories.get();
      })
      .then(function(categories) {
        $('#tb-cookie-category').autocomplete({
          source: categories
        });
        $('#btn-cookie-add').on('click', function() {
          var cookie = {
            text: $('#tb-cookie-text').val(),
            category: $('#tb-cookie-category').val()
          };

          data.cookies.add(cookie)
            .then(function(cookie) {
              toastr.success(`Cookie "${cookie.text}" added!`);
              context.redirect('#/cookies');
            });
        });
      });
  }

  return {
    all: all,
    add: add
  };
}());
