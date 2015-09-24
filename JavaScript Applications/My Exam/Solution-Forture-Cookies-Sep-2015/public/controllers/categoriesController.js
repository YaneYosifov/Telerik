var categoriesController = function () {

    function all(context) {
        templates.get('categories')
            .then(function (template) {
                context.$element().html(template());
            });
    }

    return {
        all: all
    };
}();
