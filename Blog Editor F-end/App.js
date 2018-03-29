
//Send the AJAX call to the server
$.ajax({
    //The URL to process the request
    'url' : 'http://localhost:60276/api/users',
    'type' : 'GET',
    'success' : function(data) {
        var users=document.getElementById('getUsers');
        //You can use any jQuery/JavaScript here!!!
        for(i=0;i<data.length;i++){
            var tr=document.createElement('tr');
            tr.setAttribute('class','SearchRow');
            var name=document.createElement('td');
            name.innerText=data[i].name;
            name.setAttribute("class",'searchText');
            tr.appendChild(name);
            var age=document.createElement('td');
            age.innerText=data[i].age;
            tr.appendChild(age);
            var email=document.createElement('td');
            email.innerText=data[i].email;
            tr.appendChild(email);
            var blogs=document.createElement('td');
            blogs.innerText=data[i].blogs.length;
            blogs.style.paddingLeft="50px";
            tr.appendChild(blogs);
            var profile=document.createElement('td');
            $(profile).on('click',{key:data[i].userId},storeId);
            var a=document.createElement('a');
            a.innerText="Profile";
            a.setAttribute('href','Profile.html');
            profile.appendChild(a);
            tr.appendChild(profile);
            users.appendChild(tr);
        }
    },
    'error': function (xhr, ajaxOptions, thrownError) {

        alert("Status: Failled \n Could not load from the database");
    }

});


$(document).ready(function () {

    reloadPaggination();
    function reloadPaggination() {


    $.get("http://localhost:60276/api/users/count",function (data) {
        var pages= data/5;
        var container=document.getElementById('getPages');
        while(container.childNodes.length > 1){
            container.removeChild(container.lastChild);
        }
        for(i=0;i<pages;i++){

            var li=document.createElement("li");
            var a=document.createElement('a');
            a.setAttribute("id","id"+(i+1));
            a.innerText=i+1;
            li.style.cursor="pointer";
            li.appendChild(a);
            container.appendChild(li);
            $(li).on('click',{key:(i+1)},getUsers);

        }

    });

    }

// for sorting By name and Email in same input
    $("#search").keyup(function () {


// if u want to search only inside just ur page
        var s= (document.getElementById('search').value).toUpperCase();
        var row=document.querySelectorAll('.SearchRow');
        for(i=0;i<row.length;i++){

            var nameColumn =row[i].firstElementChild;
            var emailCoulmn=row[i].children[2].innerHTML;

            if(row[i].firstElementChild||row[i].children[2]){
                if(row[i].firstElementChild.innerHTML.toUpperCase().indexOf(s)>-1||row[i].children[2].innerHTML.toUpperCase().indexOf(s)>-1){
                    row[i].style.display="";
                }
                else{
                    row[i].style.display="none";
                }
            }
        }


    });

   // id1.click({key:id1.text()},storeId);
    $("#id1").click(storeId);
});

function getUsers(n) {
    var num=n.data.key;
    $.get("http://localhost:60276/api/page/"+num,function (data) {
        var users=document.getElementById('getUsers');
        while(users.childNodes.length > 1){
            users.removeChild(users.lastChild);
        }

        for(i=0;i<data.length;i++){
            var tr=document.createElement('tr');
            tr.setAttribute('class','SearchRow');
            var name=document.createElement('td');
            name.innerText=data[i].name;
            name.setAttribute("class",'searchText');
            tr.appendChild(name);
            var age=document.createElement('td');
            age.innerText=data[i].age;
            tr.appendChild(age);
            var email=document.createElement('td');
            email.innerText=data[i].email;
            tr.appendChild(email);
            var blogs=document.createElement('td');
            blogs.innerText=data[i].blogs.length;
            tr.appendChild(blogs);
            var profile=document.createElement('td');
            $(profile).on('click',{key:data[i].userId},storeId);
            var a=document.createElement('a');
            a.innerText="Profile";
            a.setAttribute('href','Profile.html');
            profile.setAttribute('id','id'+i+"'");
            profile.appendChild(a);
            tr.appendChild(profile);
            users.appendChild(tr);
        }
    });
}

function storeId(n) {
    var num =n.data.key;
    localStorage.setItem("idOnLocal", num);
}




