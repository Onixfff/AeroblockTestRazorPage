$(document).ready(function () {
    $('#TableMain').load("/Home/GetTablePartial")
})

$(document).ready(function () {
    $.ajax({
        url: '/Home/GetState�arriage', // �������� �� ��� ����� �����������
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            if (data && data.length > 0) {
                var enumSelect = $('#enumSelect');
                $.each(data, function (index, value) {
                    enumSelect.append('<option value="' + value + '">' + value + '</option>');
                });
            } else {
                console.error("������: ��� ������ ��� �����������.");
            }
        },
        error: function (xhr, status, error) {
            console.error("������ ��� ���������� �������:", status, error);
        }
    });
});