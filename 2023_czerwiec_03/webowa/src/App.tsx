import "bootstrap/dist/css/bootstrap.css"
import "./App.css"

function App() {
  const btnClick = () => {
    console.log(
      `tytul: ${document.querySelector("input")?.value}; rodzaj: ${document.querySelector("select")?.value}`,
    )
  }

  return (
    <form className='d-flex flex-column gap-2'>
      <label htmlFor='title'>Tytuł filmu</label>
      <input name='title' type='text' />
      <label htmlFor='genre'>Rodzaj</label>
      <select name='genre'>
        <option value=''></option>
        <option value='1'>Komedia</option>
        <option value='2'>Obyczajowy</option>
        <option value='3'>Sensacyjny</option>
        <option value='4'>Horror</option>
      </select>
      <button
        type='button'
        onClick={btnClick}
        className='btn btn-primary'
        style={{ width: "fit-content" }}
      >
        Dodaj
      </button>
    </form>
  )
}

export default App
