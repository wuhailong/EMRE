(
document.onkeydown=function(event){ 
var e = event || window.event ; 
if(e && e.keyCode>=0){//���������ִ��
//Ҫ�������� 
alert("asdf");
var range = UE.getEditor('editor').selection.getRange();
range.select();
//var txt = UE.getEditor('editor').selection.getText();
UE.getEditor('editor').execCommand('strikethrough');
}
}
)();

    //ʵ�����༭��
        //����ʹ�ù�������getEditor���������ñ༭��ʵ���������ĳ���հ������øñ༭����ֱ�ӵ���UE.getEditor('editor')�����õ���ص�ʵ��
        var ue = UE.getEditor('editor');

		function bold() {
           UE.getEditor('editor').execCommand( 'bold' );
        }

        function italic() {
            ue.execCommand('italic');
		}

		function subscript() {
		    ue.execCommand('subscript');
		}

		function superscript() {
		    ue.execCommand('superscript');
		}

		function touppercase() {
		    ue.execCommand('touppercase');
		}
		function tolowercase() {
		    ue.execCommand('tolowercase');
		}

		function underline() {
		    ue.execCommand('underline');
		}
		function strikethrough() {
		    ue.execCommand('strikethrough');
		}

		function fontborder() {
		    ue.execCommand('fontborder');
		}
		function horizontal() {
		    ue.execCommand('horizontal');
		}

		function indent() {
		    ue.execCommand('indent');
		}
		function insertparagraph() {
		    ue.execCommand('insertparagraph');
		}

		function justifyR() {
		    ue.execCommand('justify', 'right');
		}
		function justifyL() {
		    ue.execCommand('justify', 'left');
		}
		function justifyC() {
		    ue.execCommand('justify', 'center');
		}
		function justifyB() {
		    ue.execCommand('justify', 'justify');
		}
		function pagebreak() {
		    ue.execCommand('pagebreak');
		}

		function preview() {
		    ue.execCommand('preview');
		}
		function print() {
		    ue.execCommand('print');
		}

		function time() {
		    ue.execCommand('time');
		}
		function date() {
		    ue.execCommand('date');
		}

		function undo() {
		    ue.execCommand('undo');
		}
		function redo() {
		    ue.execCommand('redo');
		}

		function forecolor(color) {
			
		    ue.execCommand('forecolor',color);
		}

		function backcolor(color) {
			
		    ue.execCommand('backcolor',color);
		}

		function fontsize(size) {
			
		    ue.execCommand('fontsize',size);
		}

		function fontfamily(fontfamily) {
			
		    ue.execCommand('fontfamily',fontfamily);
		}

		function paragraph(type) {
			
		    ue.execCommand('Paragraph',type,"{class:'test'}");
		}

		function insertorderedlist(type) {
			
		    ue.execCommand('insertorderedlist',type);
		}

		function insertunorderedlist(type) {
			
		    ue.execCommand('insertunorderedlist',type);
		}
		
		function rowspacingtop(height) {
			
		    ue.execCommand('rowspacing',height,'top');
		}

		function rowspacingbottom(height) {
		
		    ue.execCommand('rowspacing',height,'bottom');
		}
	
		function lineheight(height) {
		
		    ue.execCommand('lineheight',height);
		}

		function horizontal() {
		
		    ue.execCommand('horizontal');
		}

		function print() {
		
		    ue.execCommand('print');
		}

		function preview() {
		
		    ue.execCommand('preview');
		}

		function inserttable(row,col) {
			var opt = {numRows:row,
			numCols:col
			};					
		    ue.execCommand('inserttable',opt);
		}

		function deletetable() {
		
		    ue.execCommand('deletetable');
		}

		function insertparagraphbeforetable() {
		
		    ue.execCommand('insertparagraphbeforetable');
		}
		
		function insertrow() {
		
		    ue.execCommand('insertrow');
		}

		function cellalign() {
		
		    ue.execCommand('cellalign');
		}

		function cellvalign() {
		
		    ue.execCommand('cellvalign');
		}

		function insertcaption() {
		
		    ue.execCommand('insertcaption');
		}

		function deletecaption() {
		
		    ue.execCommand('deletecaption');
		}

		function inserttitle() {
		
		    ue.execCommand('inserttitle');
		}

		function deletetitle() {
		
		    ue.execCommand('deletetitle');
		}

		function inserttitlecol() {
		
		    ue.execCommand('inserttitlecol');
		}

		function deletetitlecol() {
		
		    ue.execCommand('deletetitlecol');
		}

		function mergeright() {
		
		    ue.execCommand('mergeright');
		}

		function mergedown() {
		
		    ue.execCommand('mergedown');
		}

		function mergecells() {
		
		    ue.execCommand('mergecells');
		}

		function insertrownext() {
		
		    ue.execCommand('insertrownext');
		}
		
		function deleterow() {
		
		    ue.execCommand('deleterow');
		}
		
		function insertcol() {
		
		    ue.execCommand('insertcol');
		}

		function insertcolnext() {
		
		    ue.execCommand('insertcolnext');
		}
		function deletecol() {
		
		    ue.execCommand('deletecol');
		}

		function splittocells() {
		
		    ue.execCommand('splittocells');
		}

		function splittorows() {
		
		    ue.execCommand('splittorows');
		}
		function splittocols() {
		
		    ue.execCommand('splittocols');
		}

		function cleardoc() {
		
		    ue.execCommand('cleardoc');
		}

        function isFocus(e) {
            alert(UE.getEditor('editor').isFocus());
            UE.dom.domUtils.preventDefault(e)
        }

        function setblur(e) {
            UE.getEditor('editor').blur();
            UE.dom.domUtils.preventDefault(e)
        }

        function insertHtml(value) {
            
            UE.getEditor('editor').execCommand('insertHtml', value)
        }

        function createEditor() {
            enableBtn();
            UE.getEditor('editor');
        }

        function getAllHtml() {
            return UE.getEditor('editor').getAllHtml();
        }

        function getContent() {
            return UE.getEditor('editor').getContent()
        }

        function getPlainTxt() {
            return UE.getEditor('editor').getPlainTxt()
        }

        function setContent(isAppendTo) {
            return UE.getEditor('editor').setContent('��ӭʹ��ueditor', isAppendTo)
        }

        function setDisabled() {
            UE.getEditor('editor').setDisabled('fullscreen');
            disableBtn("enable");
        }

        function setEnabled() {
            UE.getEditor('editor').setEnabled();
            enableBtn();
        }

        function getText() {
            //��������ťʱ�༭�����Ѿ�ʧȥ�˽��㣬���ֱ����getText������õ����ݣ�����Ҫ��ѡ������Ȼ��ȡ������
            var range = UE.getEditor('editor').selection.getRange();
            range.select();
            var txt = UE.getEditor('editor').selection.getText();
            return txt;
        }

        function getContentTxt() {

            return UE.getEditor('editor').getContentTxt()
        }

        function hasContent() {

            return UE.getEditor('editor').hasContents()
        }

        function setFocus() {
            UE.getEditor('editor').focus();
        }

        function deleteEditor() {
            disableBtn();
            UE.getEditor('editor').destroy();
        }

        function disableBtn(str) {
            var div = document.getElementById('btns');
            var btns = UE.dom.domUtils.getElementsByTagName(div, "button");
            for (var i = 0, btn; btn = btns[i++]; ) {
                if (btn.id == str) {
                    UE.dom.domUtils.removeAttributes(btn, ["disabled"]);
                } else {
                    btn.setAttribute("disabled", "true");
                }
            }
        }

        function enableBtn() {
            var div = document.getElementById('btns');
            var btns = UE.dom.domUtils.getElementsByTagName(div, "button");
            for (var i = 0, btn; btn = btns[i++]; ) {
                UE.dom.domUtils.removeAttributes(btn, ["disabled"]);
            }
        }

        function getLocalData() {
            return UE.getEditor('editor').execCommand("getlocaldata");
        }

        function clearLocalData() {
            UE.getEditor('editor').execCommand("clearlocaldata");
            alert("����ղݸ���")
        }