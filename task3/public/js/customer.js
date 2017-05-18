$(function () {
    $('#searchId').keyup(function () {
        var search_term = $(this).val()

        $.ajax({
            method: 'POST',
            url: 'api/search',
            data: {
                search_term
            },
            dataType: 'json',
            success: function (json) {
                var data = json.hits.hits.map(function (hit) {
                    return hit;
                });

                $('#SearchResultId').empty()

                for (var i = 0; i < data.length; i++) {
                    console.log(data[i]._id)
                    var html = ""
                    html = '<div class="col-md-4"><a href="/product/' + data[i]._id + '"><div class="thumbnail"><img src="' + data[i]._source.image + '" alt=""><div class="caption"><h3>' + data[i]._source.name + '</h3>' + data[i]._source.price + '</div></div></a></div>'
                    $('#SearchResultId').append(html)
                }
            },
            error: function (error) {
                console.log(error)
            }
        })
    })


      window.fbAsyncInit = function() {
    FB.init({
      appId      : '627465674109233',
      xfbml      : true,
      version    : 'v2.8'
    });
    FB.AppEvents.logPageView();
  };

})


