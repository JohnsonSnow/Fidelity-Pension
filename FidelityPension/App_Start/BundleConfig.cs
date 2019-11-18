using System.Web;
using System.Web.Optimization;

namespace FidelityPension
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // CSS style (bootstrap/inspinia)
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Areas/Content/bootstrap.min.css",
                      "~/Areas/Content/animate.css",
                      "~/Areas/Content/style.css"));

            // Font Awesome icons
            bundles.Add(new StyleBundle("~/font-awesome/css").Include(
                      "~/Areas/fonts/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Areas/Scripts/jquery-2.1.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // jQueryUI CSS
            bundles.Add(new ScriptBundle("~/Scripts/plugins/jquery-ui/jqueryuiStyles").Include(
                        "~/Areas/Scripts/plugins/jquery-ui/jquery-ui.min.css"));

            // jQueryUI 
            bundles.Add(new StyleBundle("~/bundles/jqueryui").Include(
                        "~/Areas/Scripts/plugins/jquery-ui/jquery-ui.min.js"));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Areas/Scripts/popper.min.js",
                      "~/Areas/Scripts/bootstrap.min.js"));

            // Inspinia script
            bundles.Add(new ScriptBundle("~/bundles/inspinia").Include(
                      "~/Areas/Scripts/plugins/metisMenu/jquery.metisMenu.js",
                      "~/Areas/Scripts/plugins/pace/pace.min.js",
                      "~/Areas/Scripts/app/inspinia.js"));

            // Inspinia skin config script
            bundles.Add(new ScriptBundle("~/bundles/skinConfig").Include(
                      "~/Areas/Scripts/app/skin.config.min.js"));

            // SlimScroll
            bundles.Add(new ScriptBundle("~/plugins/slimScroll").Include(
                      "~/Areas/Scripts/plugins/slimscroll/jquery.slimscroll.min.js"));

            // Peity
            bundles.Add(new ScriptBundle("~/plugins/peity").Include(
                      "~/Areas/Scripts/plugins/peity/jquery.peity.min.js"));

            // Video responsible
            bundles.Add(new ScriptBundle("~/plugins/videoResponsible").Include(
                      "~/Areas/Scripts/plugins/video/responsible-video.js"));

            // Lightbox gallery css styles
            bundles.Add(new StyleBundle("~/Content/plugins/blueimp/css/").Include(
                      "~/Content/plugins/blueimp/css/blueimp-gallery.min.css"));

            // Lightbox gallery
            bundles.Add(new ScriptBundle("~/plugins/lightboxGallery").Include(
                      "~/Areas/Scripts/plugins/blueimp/jquery.blueimp-gallery.min.js"));

            // Sparkline
            bundles.Add(new ScriptBundle("~/plugins/sparkline").Include(
                      "~/Areas/Scripts/plugins/sparkline/jquery.sparkline.min.js"));

            // Morriss chart css styles
            bundles.Add(new StyleBundle("~/plugins/morrisStyles").Include(
                      "~/Content/plugins/morris/morris-0.4.3.min.css"));

            // Morriss chart
            bundles.Add(new ScriptBundle("~/plugins/morris").Include(
                      "~/Areas/Scripts/plugins/morris/raphael-2.1.0.min.js",
                      "~/Areas/Scripts/plugins/morris/morris.js"));

            // Flot chart
            bundles.Add(new ScriptBundle("~/plugins/flot").Include(
                      "~/Areas/Scripts/plugins/flot/jquery.flot.js",
                      "~/Areas/Scripts/plugins/flot/jquery.flot.tooltip.min.js",
                      "~/Areas/Scripts/plugins/flot/jquery.flot.resize.js",
                      "~/Areas/Scripts/plugins/flot/jquery.flot.pie.js",
                      "~/Areas/Scripts/plugins/flot/jquery.flot.time.js",
                      "~/Areas/Scripts/plugins/flot/jquery.flot.spline.js"));

            // Rickshaw chart
            bundles.Add(new ScriptBundle("~/plugins/rickshaw").Include(
                      "~/Areas/Scripts/plugins/rickshaw/vendor/d3.v3.js",
                      "~/Areas/Scripts/plugins/rickshaw/rickshaw.min.js"));

            // ChartJS chart
            bundles.Add(new ScriptBundle("~/plugins/chartJs").Include(
                      "~/Areas/Scripts/plugins/chartjs/Chart.min.js"));

            // iCheck css styles
            bundles.Add(new StyleBundle("~/Content/plugins/iCheck/iCheckStyles").Include(
                      "~/Content/plugins/iCheck/custom.css"));

            // iCheck
            bundles.Add(new ScriptBundle("~/plugins/iCheck").Include(
                      "~/Areas/Scripts/plugins/iCheck/icheck.min.js"));

            // dataTables css styles
            bundles.Add(new StyleBundle("~/Content/plugins/dataTables/dataTablesStyles").Include(
                      "~/Areas/Content/plugins/dataTables/datatables.min.css"));

            // dataTables 
            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
                      "~/Areas/Scripts/plugins/dataTables/datatables.min.js"));

            // jeditable 
            bundles.Add(new ScriptBundle("~/plugins/jeditable").Include(
                      "~/Areas/Scripts/plugins/jeditable/jquery.jeditable.js"));

            // jqGrid styles
            bundles.Add(new StyleBundle("~/Content/plugins/jqGrid/jqGridStyles").Include(
                      "~/Content/plugins/jqGrid/ui.jqgrid.css"));

            // jqGrid 
            bundles.Add(new ScriptBundle("~/plugins/jqGrid").Include(
                      "~/Areas/Scripts/plugins/jqGrid/i18n/grid.locale-en.js",
                      "~/Areas/Scripts/plugins/jqGrid/jquery.jqGrid.min.js"));

            // codeEditor styles
            bundles.Add(new StyleBundle("~/plugins/codeEditorStyles").Include(
                      "~/Content/plugins/codemirror/codemirror.css",
                      "~/Content/plugins/codemirror/ambiance.css"));

            // codeEditor 
            bundles.Add(new ScriptBundle("~/plugins/codeEditor").Include(
                      "~/Areas/Scripts/plugins/codemirror/codemirror.js",
                      "~/Areas/Scripts/plugins/codemirror/mode/javascript/javascript.js"));

            // codeEditor 
            bundles.Add(new ScriptBundle("~/plugins/nestable").Include(
                      "~/Areas/Scripts/plugins/nestable/jquery.nestable.js"));






            // validate 
            bundles.Add(new ScriptBundle("~/plugins/validate").Include(
                      "~/Areas/Scripts/plugins/validate/jquery.validate.min.js"));



            // fullCalendar styles
            bundles.Add(new StyleBundle("~/plugins/fullCalendarStyles").Include(
                      "~/Areas/Content/plugins/fullcalendar/fullcalendar.css"));

            // fullCalendar 
            bundles.Add(new ScriptBundle("~/plugins/fullCalendar").Include(
                      "~/Areas/Scripts/plugins/fullcalendar/moment.min.js",
                      "~/Areas/Scripts/plugins/fullcalendar/fullcalendar.min.js"));

            // vectorMap 
            bundles.Add(new ScriptBundle("~/plugins/vectorMap").Include(
                      "~/Areas/Scripts/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                      "~/Areas/Scripts/plugins/jvectormap/jquery-jvectormap-world-mill-en.js"));

            // ionRange styles
            bundles.Add(new StyleBundle("~/Content/plugins/ionRangeSlider/ionRangeStyles").Include(
                      "~/Areas/Content/plugins/ionRangeSlider/ion.rangeSlider.css",
                      "~/Areas/Content/plugins/ionRangeSlider/ion.rangeSlider.skinFlat.css"));

            // ionRange 
            bundles.Add(new ScriptBundle("~/plugins/ionRange").Include(
                      "~/Areas/Scripts/plugins/ionRangeSlider/ion.rangeSlider.min.js"));

            // dataPicker styles
            bundles.Add(new StyleBundle("~/plugins/dataPickerStyles").Include(
                      "~/Areas/Content/plugins/datapicker/datepicker3.css"));

            // dataPicker 
            bundles.Add(new ScriptBundle("~/plugins/dataPicker").Include(
                      "~/Areas/Scripts/plugins/datapicker/bootstrap-datepicker.js"));

            // nouiSlider styles
            bundles.Add(new StyleBundle("~/plugins/nouiSliderStyles").Include(
                      "~/Areas/Content/plugins/nouslider/jquery.nouislider.css"));

            // nouiSlider 
            bundles.Add(new ScriptBundle("~/plugins/nouiSlider").Include(
                      "~/Areas/Scripts/plugins/nouslider/jquery.nouislider.min.js"));

            // jasnyBootstrap styles
            bundles.Add(new StyleBundle("~/plugins/jasnyBootstrapStyles").Include(
                      "~/Areas/Content/plugins/jasny/jasny-bootstrap.min.css"));

            // jasnyBootstrap 
            bundles.Add(new ScriptBundle("~/plugins/jasnyBootstrap").Include(
                      "~/Areas/Scripts/plugins/jasny/jasny-bootstrap.min.js"));

            // switchery styles
            bundles.Add(new StyleBundle("~/plugins/switcheryStyles").Include(
                      "~/Areas/Content/plugins/switchery/switchery.css"));

            // switchery 
            bundles.Add(new ScriptBundle("~/plugins/switchery").Include(
                      "~/Areas/Scripts/plugins/switchery/switchery.js"));

            // chosen styles
            bundles.Add(new StyleBundle("~/Content/plugins/chosen/chosenStyles").Include(
                      "~/Areas/Content/plugins/chosen/bootstrap-chosen.css"));

            // chosen 
            bundles.Add(new ScriptBundle("~/plugins/chosen").Include(
                      "~/Areas/Scripts/plugins/chosen/chosen.jquery.js"));

            // knob 
            bundles.Add(new ScriptBundle("~/plugins/knob").Include(
                      "~/Areas/Scripts/plugins/jsKnob/jquery.knob.js"));

            // wizardSteps styles
            bundles.Add(new StyleBundle("~/plugins/wizardStepsStyles").Include(
                      "~/Areas/Content/plugins/steps/jquery.steps.css"));

            // wizardSteps 
            bundles.Add(new ScriptBundle("~/plugins/wizardSteps").Include(
                      "~/Areas/Scripts/plugins/steps/jquery.steps.min.js"));

            // dropZone styles
            bundles.Add(new StyleBundle("~/Content/plugins/dropzone/dropZoneStyles").Include(
                      "~/Areas/Content/plugins/dropzone/basic.css",
                      "~/Areas/Content/plugins/dropzone/dropzone.css"));

            // dropZone 
            bundles.Add(new ScriptBundle("~/plugins/dropZone").Include(
                      "~/Areas/Scripts/plugins/dropzone/dropzone.js"));

            // summernote styles
            bundles.Add(new StyleBundle("~/plugins/summernoteStyles").Include(
                      "~/Areas/Content/plugins/summernote/summernote-bs4.css"));

            // summernote 
            bundles.Add(new ScriptBundle("~/plugins/summernote").Include(
                      "~/Areas/Scripts/plugins/summernote/summernote-bs4.js"));

            // toastr notification 
            bundles.Add(new ScriptBundle("~/plugins/toastr").Include(
                      "~/Areas/Scripts/plugins/toastr/toastr.min.js"));

            // toastr notification styles
            bundles.Add(new StyleBundle("~/plugins/toastrStyles").Include(
                      "~/Areas/Content/plugins/toastr/toastr.min.css"));

            // color picker
            bundles.Add(new ScriptBundle("~/plugins/colorpicker").Include(
                      "~/Areas/Scripts/plugins/colorpicker/bootstrap-colorpicker.min.js"));

            // color picker styles
            bundles.Add(new StyleBundle("~/Content/plugins/colorpicker/colorpickerStyles").Include(
                      "~/Areas/Content/plugins/colorpicker/bootstrap-colorpicker.min.css"));

            // image cropper
            bundles.Add(new ScriptBundle("~/plugins/imagecropper").Include(
                      "~/Areas/Scripts/plugins/cropper/cropper.min.js"));

            // image cropper styles
            bundles.Add(new StyleBundle("~/plugins/imagecropperStyles").Include(
                      "~/Areas/Content/plugins/cropper/cropper.min.css"));

            // jsTree
            bundles.Add(new ScriptBundle("~/plugins/jsTree").Include(
                      "~/Areas/Scripts/plugins/jsTree/jstree.min.js"));

            // jsTree styles
            bundles.Add(new StyleBundle("~/Content/plugins/jsTree").Include(
                      "~/Areas/Content/plugins/jsTree/style.css"));

            // Diff
            bundles.Add(new ScriptBundle("~/plugins/diff").Include(
                      "~/Areas/Scripts/plugins/diff_match_patch/javascript/diff_match_patch.js",
                      "~/Areas/Scripts/plugins/preetyTextDiff/jquery.pretty-text-diff.min.js"));

            // Idle timer
            bundles.Add(new ScriptBundle("~/plugins/idletimer").Include(
                      "~/Areas/Scripts/plugins/idle-timer/idle-timer.min.js"));

            // Tinycon
            bundles.Add(new ScriptBundle("~/plugins/tinycon").Include(
                      "~/Areas/Scripts/plugins/tinycon/tinycon.min.js"));

            // Chartist
            bundles.Add(new StyleBundle("~/plugins/chartistStyles").Include(
                      "~/Areas/Content/plugins/chartist/chartist.min.css"));

            // jsTree styles
            bundles.Add(new ScriptBundle("~/plugins/chartist").Include(
                      "~/Areas/Scripts/plugins/chartist/chartist.min.js"));

            // Awesome bootstrap checkbox
            bundles.Add(new StyleBundle("~/plugins/awesomeCheckboxStyles").Include(
                      "~/Areas/Content/plugins/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css"));

            // Clockpicker styles
            bundles.Add(new StyleBundle("~/plugins/clockpickerStyles").Include(
                      "~/Areas/Content/plugins/clockpicker/clockpicker.css"));

            // Clockpicker
            bundles.Add(new ScriptBundle("~/plugins/clockpicker").Include(
                      "~/Areas/Scripts/plugins/clockpicker/clockpicker.js"));

            // Date range picker Styless
            bundles.Add(new StyleBundle("~/plugins/dateRangeStyles").Include(
                      "~/Areas/Content/plugins/daterangepicker/daterangepicker-bs3.css"));

            // Date range picker
            bundles.Add(new ScriptBundle("~/plugins/dateRange").Include(
                      // Date range use moment.js same as full calendar plugin 
                      "~/Areas/Scripts/plugins/fullcalendar/moment.min.js",
                      "~/Areas/Scripts/plugins/daterangepicker/daterangepicker.js"));

            // Sweet alert Styless
            bundles.Add(new StyleBundle("~/plugins/sweetAlertStyles").Include(
                      "~/Areas/Content/plugins/sweetalert/sweetalert.css"));

            // Sweet alert
            bundles.Add(new ScriptBundle("~/plugins/sweetAlert").Include(
                      "~/Areas/Scripts/plugins/sweetalert/sweetalert.min.js"));

            // Footable Styless
            bundles.Add(new StyleBundle("~/plugins/footableStyles").Include(
                      "~/Areas/Content/plugins/footable/footable.core.css", new CssRewriteUrlTransform()));

            // Footable alert
            bundles.Add(new ScriptBundle("~/plugins/footable").Include(
                      "~/Areas/Scripts/plugins/footable/footable.all.min.js"));

            // Select2 Styless
            bundles.Add(new StyleBundle("~/plugins/select2Styles").Include(
                      "~/Areas/Content/plugins/select2/select2.min.css"));

            // Select2
            bundles.Add(new ScriptBundle("~/plugins/select2").Include(
                      "~/Areas/Scripts/plugins/select2/select2.full.min.js"));

            // Masonry
            bundles.Add(new ScriptBundle("~/plugins/masonry").Include(
                      "~/Areas/Scripts/plugins/masonary/masonry.pkgd.min.js"));

            // Slick carousel Styless
            bundles.Add(new StyleBundle("~/plugins/slickStyles").Include(
                      "~/Areas/Content/plugins/slick/slick.css", new CssRewriteUrlTransform()));

            // Slick carousel theme Styless
            bundles.Add(new StyleBundle("~/plugins/slickThemeStyles").Include(
                      "~/Areas/Content/plugins/slick/slick-theme.css", new CssRewriteUrlTransform()));

            // Slick carousel
            bundles.Add(new ScriptBundle("~/plugins/slick").Include(
                      "~/Areas/Scripts/plugins/slick/slick.min.js"));

            // Ladda buttons Styless
            bundles.Add(new StyleBundle("~/plugins/laddaStyles").Include(
                      "~/Areas/Content/plugins/ladda/ladda-themeless.min.css"));

            // Ladda buttons
            bundles.Add(new ScriptBundle("~/plugins/ladda").Include(
                      "~/Areas/Scripts/plugins/ladda/spin.min.js",
                      "~/Areas/Scripts/plugins/ladda/ladda.min.js",
                      "~/Areas/Scripts/plugins/ladda/ladda.jquery.min.js"));

            // Dotdotdot buttons
            bundles.Add(new ScriptBundle("~/plugins/truncate").Include(
                      "~/Areas/Scripts/plugins/dotdotdot/jquery.dotdotdot.min.js"));

            // Touch Spin Styless
            bundles.Add(new StyleBundle("~/plugins/touchSpinStyles").Include(
                      "~/Areas/Content/plugins/touchspin/jquery.bootstrap-touchspin.min.css"));

            // Touch Spin
            bundles.Add(new ScriptBundle("~/plugins/touchSpin").Include(
                      "~/Areas/Scripts/plugins/touchspin/jquery.bootstrap-touchspin.min.js"));

            // Tour Styless
            bundles.Add(new StyleBundle("~/plugins/tourStyles").Include(
                      "~/Areas/Content/plugins/bootstrapTour/bootstrap-tour.min.css"));

            // Tour Spin
            bundles.Add(new ScriptBundle("~/plugins/tour").Include(
                      "~/Areas/Scripts/plugins/bootstrapTour/bootstrap-tour.min.js"));

            // i18next Spin
            bundles.Add(new ScriptBundle("~/plugins/i18next").Include(
                      "~/Areas/Scripts/plugins/i18next/i18next.min.js"));

            // Clipboard Spin
            bundles.Add(new ScriptBundle("~/plugins/clipboard").Include(
                      "~/Areas/Scripts/plugins/clipboard/clipboard.min.js"));

            // c3 Styless
            bundles.Add(new StyleBundle("~/plugins/c3Styles").Include(
                      "~/Areas/Content/plugins/c3/c3.min.css"));

            // c3 Charts
            bundles.Add(new ScriptBundle("~/plugins/c3").Include(
                      "~/Areas/Scripts/plugins/c3/c3.min.js"));

            // D3
            bundles.Add(new ScriptBundle("~/plugins/d3").Include(
                      "~/Areas/Scripts/plugins/d3/d3.min.js"));

            // Markdown Styless
            bundles.Add(new StyleBundle("~/plugins/markdownStyles").Include(
                      "~/Areas/Content/plugins/bootstrap-markdown/bootstrap-markdown.min.css"));

            // Markdown 
            bundles.Add(new ScriptBundle("~/plugins/markdown").Include(
                      "~/Areas/Scripts/plugins/bootstrap-markdown/bootstrap-markdown.js",
                      "~/Areas/Scripts/plugins/bootstrap-markdown/markdown.js"));

            // Datamaps
            bundles.Add(new ScriptBundle("~/plugins/datamaps").Include(
                      "~/Areas/Scripts/plugins/topojson/topojson.js",
                      "~/Areas/Scripts/plugins/datamaps/datamaps.all.min.js"));

            // Taginputs Styless
            bundles.Add(new StyleBundle("~/plugins/tagInputsStyles").Include(
                      "~/Areas/Content/plugins/bootstrap-tagsinput/bootstrap-tagsinput.css"));

            // Taginputs
            bundles.Add(new ScriptBundle("~/plugins/tagInputs").Include(
                      "~/Areas/Scripts/plugins/bootstrap-tagsinput/bootstrap-tagsinput.js"));

            // Duallist Styless
            bundles.Add(new StyleBundle("~/plugins/duallistStyles").Include(
                      "~/Areas/Content/plugins/bootstrap-tagsinput/bootstrap-tagsinput.css"));

            // Duallist
            bundles.Add(new ScriptBundle("~/plugins/duallist").Include(
                      "~/Areas/Scripts/plugins/dualListbox/jquery.bootstrap-duallistbox.js"));

            // SocialButtons styles
            bundles.Add(new StyleBundle("~/plugins/socialButtonsStyles").Include(
                      "~/Areas/Content/plugins/bootstrapSocial/bootstrap-social.css"));

            // Typehead
            bundles.Add(new ScriptBundle("~/plugins/typehead").Include(
                      "~/Areas/Scripts/plugins/typehead/bootstrap3-typeahead.min.js"));

            // Pdfjs
            bundles.Add(new ScriptBundle("~/plugins/pdfjs").Include(
                      "~/Areas/Scripts/plugins/pdfjs/pdf.js"));

            // Touch Punch 
            bundles.Add(new StyleBundle("~/plugins/touchPunch").Include(
                        "~/Areas/Scripts/plugins/touchpunch/jquery.ui.touch-punch.min.js"));

            // WOW 
            bundles.Add(new StyleBundle("~/plugins/wow").Include(
                        "~/Areas/Scripts/plugins/wow/wow.min.js"));

            // Text spinners styles
            bundles.Add(new StyleBundle("~/plugins/textSpinnersStyles").Include(
                      "~/Areas/Content/plugins/textSpinners/spinners.css"));

            // Password meter 
            bundles.Add(new StyleBundle("~/plugins/passwordMeter").Include(
                        "~/Areas/Scripts/plugins/pwstrength/pwstrength-bootstrap.min.js",
                        "~/Areas/Scripts/plugins/pwstrength/zxcvbn.js"));
        }
    }
}
