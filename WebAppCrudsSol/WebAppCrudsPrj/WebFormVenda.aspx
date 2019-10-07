<%@ Page Title="Vendas" Language="C#" MasterPageFile="~/Mestre.Master" AutoEventWireup="true" CodeBehind="WebFormVenda.aspx.cs" Inherits="WebAppCrudsPrj.WebFormVenda"  Theme="Tema1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
// External JS: JS Helper Functions
// External JS: Dynamics JS

var btnOpen = select('.js-open');
var btnClose = select('.js-close');
var modal = select('.js-modal');
var modalChildren = modal.children;

function hideModal() {
  dynamics.animate(modal, {
    opacity: 0,
    translateY: 100
  }, {
    type: dynamics.spring,
    frequency: 50,
    friction: 600,
    duration: 1500
  });
}

function showModal() {
  // Define initial properties
  dynamics.css(modal, {
    opacity: 0,
    scale: .5
  });
  
  // Animate to final properties
  dynamics.animate(modal, {
    opacity: 1,
    scale: 1
  }, {
    type: dynamics.spring,
    frequency: 300,
    friction: 400,
    duration: 1000
  });
}

function showBtn() {
  dynamics.css(btnOpen, {
    opacity: 0
  });
  
  dynamics.animate(btnOpen, {
    opacity: 1
  }, {
    type: dynamics.spring,
    frequency: 300,
    friction: 400,
    duration: 800
  });
}

function showModalChildren() {
  // Animate each child individually
  for(var i=0; i<modalChildren.length; i++) {
    var item = modalChildren[i];
    
    // Define initial properties
    dynamics.css(item, {
      opacity: 0,
      translateY: 30
    });

    // Animate to final properties
    dynamics.animate(item, {
      opacity: 1,
      translateY: 0
    }, {
      type: dynamics.spring,
      frequency: 300,
      friction: 400,
      duration: 1000,
      delay: 100 + i * 40
    });
  } 
}

function toggleClasses() {
  toggleClass(btnOpen, 'is-active');
  toggleClass(modal, 'is-active');
}

// Open nav when clicking sandwich button
btnOpen.addEventListener('click', function(e) {
  toggleClasses();
  showModal();
  showModalChildren();
});

// Open nav when clicking sandwich button
btnClose.addEventListener('click', function(e) {
  hideModal();
  dynamics.setTimeout(toggleClasses, 500);
  dynamics.setTimeout(showBtn, 500);
});
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
          <h1>Nova Venda</h1>
          <p>Preencha todos os campos</p>
      
              <label for="id"><b>ID</b></label>
            <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
         
            <label for="date"><b>Data</b></label><br />
            <asp:TextBox ID="TextBoxData" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
          <label for="cpf"><b>Novo Item       </b></label>
            <br />
 <div class="wrap">
  <button class="js-open btn-open is-active">Show modal</button>
  <div class="modal js-modal">
    <div class="modal-image">
      <svg viewBox="0 0 32 32" style="fill:#48DB71"><path d="M1 14 L5 10 L13 18 L27 4 L31 8 L13 26 z"></path></svg>
    </div>
    <h1>Nice job!</h1>
    <p>To dismiss click the button below</p>
    <button class="js-close">Dismiss</button>
  </div>
</div>
      
            <br />
            <br />
          <div class="clearfix">
      
            <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" />
          </div>
        </div>






</asp:Content>
