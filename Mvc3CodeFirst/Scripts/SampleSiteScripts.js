
$(document).ready(function () {

    SampleSite.Initialize();
});

var SampleSite = {

    Initialize: function () {

        $("[data-type='action']")
            .closest("[data-type='row']")
            .mouseover(function () { $(this).find("[data-type='action']").removeClass("action-container"); })
            .mouseout(function () { $(this).find("[data-type='action']").addClass("action-container"); });

        $(".action-container")
            .children()
            .each(function () {
                $(this).mouseover(function () { $(this).addClass("hover"); $(this).children("i").first().addClass("hover"); })
                       .mouseout(function () { $(this).removeClass("hover"); $(this).children("i").first().removeClass("hover"); });
            });

        $("a[href='#']").click(function () { alert("This link is a placeholder. It will redirect to the related subject view later.");});

        var activeId = $("#body section > div").first().attr("data-id");
        $("#menu li a").removeClass("active");
        $("#menu li[id='" + activeId + "'] a").addClass("active");
    }
}
