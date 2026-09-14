namespace soporteticket.Logica
public class Gestor Ticker{
    public List <tecnico> LST tecnicos
    {Get;} {Set;}
    public List <Solicitante> LST Solicitantes
    {Get;} {Set;}
    public List <ticket> LST tickets
    {Get;} {Set;}

    public Gestor ticket () {
        LST Tecnicos - NEW List <Tecnico> (),
        LST Solicitantes - NEW List <Solicitante>(),
        LST Ticket - NEW List <ticket>(),}


    public Ticket CrearTicket (int ins Numero, string 
    STR Asunto,string sin descripcion, string str Categoria,
    string sin prioridad Solicitante objSolicitante )

    // Validaciones 

    ticket objTicket - NEW ticket (intNumero),
    strAsunto, Str Descripcion, strcategoria, strPrioridad.objSolicitante
    objTicket asignar Tenico (objtecnico);
    listTicket add (objTicket),
    retur objTicket; }
    public ticket burcarTicket(int int ticket);
    {
        ticketobjTicket -
        LST ticket. Find
        (t- t. int numero --)
    }
    





}