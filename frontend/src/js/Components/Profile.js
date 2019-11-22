import Skills from './Skills'
import apiActions from '../apiActions/apiActions'

export default function Profile(profile) { 
    apiActions.getRequest("https://localhost:44355/api/skills", skills => {

        
    })
    return `

        ${Skills()}
    `
}